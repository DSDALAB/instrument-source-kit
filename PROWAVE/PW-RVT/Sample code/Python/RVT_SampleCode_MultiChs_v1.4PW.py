import threading
import os, sys, glob, serial, time, datetime, ctypes
import numpy as np
from queue import Queue
import pandas as pd
from datetime import datetime

DATA_LEGNTH = 3
np.set_printoptions(threshold=np.inf)
# 子執行緒類別
class ServiceThread(threading.Thread):
    def __init__(self, num, port, queue, port_baud=3000000,
                 bytesize=8, parity='N', stopbits=1, timeout=3,
                 sampleRate=7812):
        threading.Thread.__init__(self)
        self.num = num
        self.port = port
        self.port_baud = port_baud
        self.bytesize = bytesize
        self.parity = parity
        self.stopbits = stopbits
        self.timeout = timeout
        self.sampleRate = sampleRate
        self._stopper = threading.Event()
        self.turn_gravity = 8192
        self.queue = queue
        self.maxqsize = 10
        
    def stopIt(self):
        self._stopper.set()
 
    def stopped(self):
        return self._stopper.isSet()
        
    def run(self):
        
        sampleRate = self.sampleRate
        queue = self.queue
        client = ModbusClient(method='RTU',
                              port=self.port, 
                              baudrate=self.port_baud,
                              bytesize=self.bytesize,
                              parity=self.parity,
                              stopbits=self.stopbits,
                              timeout=self.timeout
                              )
        connection = client.connect()
        #time.sleep(2) # star up delay after the port is opened
        
        # Read start_address, count, slave_id
        vib_dat = client.read_input_registers(0x80, 3, unit=1)  
        print(f"ChipID: {hex(vib_dat.registers[0])}, {hex(vib_dat.registers[1])}, {hex(vib_dat.registers[2])}")
        print(f"SampleRate: {sampleRate}")
        
        # Write SampleRate
        client.write_register(0x01, sampleRate, unit=1)
        # Read 剩餘資料長度
        vib_dat = client.read_input_registers(0x02, 1, unit=1)
        prev_data_len = 0
        data_len = vib_dat.registers[0] # 更新剩餘資料長度
        counter = 0
        print(f"Data Length: {data_len}")
        maxSize = (41 * 3)  # Modbus封包最大長度 41個封包，每包含3個值分別為X,Y,Z
        turn_gravity = self.turn_gravity # 轉G值
        
        # buffer 設定
        readqsize = 8192 # 滿多少sample才從buffer讀出來
        buffer = np.empty((0, 3), float)
        del_index = np.arange(0, readqsize, 1, int)
        
        while True:
            if self.stopped():
                client.close()
                return
            
            start = time.perf_counter()
            
            if data_len >= maxSize:     # 最多一次可抓 maxSize個值
                vib_dat = client.read_input_registers(0x02, 1+maxSize, unit=1)
            elif data_len <= (2 * 3):   # 若感測器buffer不超過6個值，則只更新剩餘資料長度，不抓值
                time.sleep(0.001)
                vib_dat = client.read_input_registers(0x02, 1, unit=1)
                continue
            else:   
                vib_dat = client.read_input_registers(0x02, data_len + 1, unit=1)
            
            end = time.perf_counter()            
            
            # Debug用，每10次迴圈Print 剩餘長度與一個封包
            # counter = counter + 1
            # if counter >= 10:
                
                # counter = 0
                # start1 = time.perf_counter()
                # print("{} ".format(self.port),
                      # "{}ms".format((end - start) * 1000), 
                      # "Data Length: 共:{} 增加:{} X:{} Y:{} Z:{}".format(
                                    # vib_dat.registers[0],
                                    # (vib_dat.registers[0] - prev_data_len),
                                    # ctypes.c_int16(vib_dat.registers[1]),
                                    # ctypes.c_int16(vib_dat.registers[2]),
                                    # ctypes.c_int16(vib_dat.registers[3])))
            
            
            data_len = vib_dat.registers[0] # 下一輪從感測器撈多少資料
            # print("剩餘長度:",data_len)
            # 資料轉為G值，並改以 筆數x三軸 的陣列
            # data = np.int16(vib_dat.registers[1:]) # Debug用 數值+9的Ramp模擬訊號
            #data = np.int16(vib_dat.registers[1:]) / self.turn_gravity # 振動轉G值
            data = np.array(vib_dat.registers[1:], dtype=np.uint16).astype(np.int16) / self.turn_gravity
            data = data.reshape((-1, 3))
            
            
            buffer = np.row_stack((buffer, data))
            
            # Buffer每滿readqsize資料，則打包放進Queue
            if buffer.shape[0] > readqsize:
                # 超過max queue size則丟棄一個element，並發出警示訊息
                while queue.qsize() > self.maxqsize:
                    print("Warning! Queue Overwrite")
                    log_data = f"Compute time ={datetime.now()},Port{port}:Warning!Queue Overwrite"
                # 寫log
                    with open("Error.txt", "a") as log_file:
                      log_file.write(log_data+ "\n")
                                 
                # print("buffer row",buffer.shape[0])
                queue.put(buffer[:readqsize]) # 放新資料進Queue
                buffer = np.delete(buffer, del_index, axis=0)
                # print("after buffer row",buffer.shape[0])
                
            
        time.sleep(1)
        

def get_existed_serial_ports():
    if sys.platform.startswith('win'):
        ports = ['COM%s' % (i + 1) for i in range(256)]
    elif sys.platform.startswith('linux') or sys.platform.startswith('cygwin'):
        # this excludes your current terminal '/dev/tty'
        # ports = glob.glob('/dev/serial*')
        ports = glob.glob('/dev/ttyUSB*')
        # Linux系統時自動下指令修改所有port的Latency timer從16ms降為1ms，加快收資料速度
        # 若有異常可將下面for loop註解掉
        # for port in ports:
        #     bashCommand = 'sudo bash -c "echo 1 > /sys/bus/usb-serial/devices/ttyUSB' + port.split('USB')[-1] + '/latency_timer"'
        #     print(bashCommand)
        #     subprocess.run(bashCommand, shell=True, check=True, executable='/bin/bash')
    elif sys.platform.startswith('darwin'):
        ports = glob.glob('/dev/tty.*')
    else:
        raise EnvironmentError('Unsupported platform')

    # to check if serial exist
    result = []
    for port in ports:
        try:
            s = serial.Serial(port)
            s.close()
            result.append(port)
        except (OSError, serial.SerialException):
            pass
    return result

if __name__=='__main__':
    current_path = os.path.dirname(os.path.abspath(__file__))
    sys.path.insert(0, current_path + '/site-packages')
    from pymodbus.client.sync import ModbusSerialClient as ModbusClient #pymodbus Ver:2.5.2  
    
    ports = get_existed_serial_ports()
    print("Existed Port:", ports)
    
    queues = ()
    q = (Queue(),) 
    qMap = {}

    # 建立多個子執行緒
    ServiceThreads = []
    end = [0,0]
    start = [0,0]
    for idx, port in enumerate(ports):
        queues = queues + q
        qMap[port] = idx            # 幫COM Port標索引數字 如map = {'COM 4': 0, 'COM 1': 1}
        ServiceThreads.append(ServiceThread(idx,port,queues[idx]))
        ServiceThreads[idx].start()
        # log檔名稱
    log_file_base = "log_"

    # 获取当前日期
    current_date = datetime.now().strftime("%Y-%m-%d")

    # 构建日志文件名
    log_file_name = log_file_base + current_date + ".txt"
    # 主執行緒繼續執行自己的工作
    # ...
    # time.sleep(5) # Delay 5秒製造 Queue滿的warning，debug用
    start[0] = time.time()
    start[1] = time.time()
    # 主程式 Start ==================================================================
    
    try:
        while True:
            for idx, port in enumerate(ports):                         
                if queues[idx].qsize() >= 1:
                  # 取得新的資料
                  msg = queues[idx].get()
                  
                  # df = pd.DataFrame(msg)
                  # df.to_csv('file.csv', index=False)
                  # 處理資料                          
                  data_jsonStr = {"port": port, 
                       "vibrationData": msg                     
                  }               
                  end[idx] = time.time()
                  msg_str = str(msg)
#                  print(msg_str)
#                 print(f"Computation time = {1000*(end - start):.3f}ms")
                  print(f"index = {idx},Compute time ={datetime.now()},{len(msg)}")
#                  print(datetime.now())
##--------寫LOG--------------------------------------------------------------------------------                  
                  log_data = f"index = {idx},Compute time ={datetime.now()},{len(msg)}"
                # 写入文件
                  with open(log_file_name, "a") as log_file:
                      log_file.write(log_data+ "\n")
##---------------------------------------------------------------------------------------------

                  start[idx] = time.time()                  
                  #print(data_jsonStr)
            time.sleep(0.1)     # 每0.1s檢查queue的狀況
    except KeyboardInterrupt:
        print('interrupted!')  #ctrl+c
              
    # 主程式 end ====================================================================
    
    for idx, x in enumerate(ports):
      ServiceThreads[idx].stopIt()
    
    
    # 等待所有子執行緒結束
    for idx, x in enumerate(ports):
      ServiceThreads[idx].join()

    print("Done.")