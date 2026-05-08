using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.IO.Ports;
using System.Text;
using Modbus.Device;
using System.Linq;
using System.Threading;
using NLog;


namespace ITIR_RVT_SampleCode
{
    public partial class Form1 : Form
    {
        private ModbusSerialMaster m_master;
        private SerialPort m_serialPort;
        private byte m_slaveid = 0x01;       //SlaveId
        private ushort m_sampleRate = 7812;  //SampleRatea(不可改變)
        private ushort m_sensorRange = 8192; //Sensor Range (±4G)(對應型號)
        private ushort m_pointCount = 8192;  //顯示資料長度
        private Thread m_ReceiveSerialPort;
        private delegate void DrawUIShowEvent(object data);
        private delegate void textShowEevent(LogLevel level,string text,bool isVisble);
        private DataTable m_dt = new DataTable();
        private bool m_receive_startSR = false;
        private int m_secOverFlowCount = 0;
        private int m_isNullCount = 0;
        private string[] m_dtColumns = new string[] { "X", "Y", "Z"};
        
        private Logger m_logger = NLog.LogManager.GetCurrentClassLogger(); //NLog紀錄

        public enum LogLevel
        { 
            Info,
            Debug,
            Error
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] port_name = SerialPort.GetPortNames();//取得電腦上所有SerialPort
            comboBox_COMPort.Items.AddRange(port_name);
            if (port_name.Length != 0)
            {
                comboBox_COMPort.SelectedIndex = 0;
            }
            button_Export.Enabled = false;
            label_SampleRateValue.Text = "SampleRate："+m_sampleRate.ToString();
            label_Count.Text = "Count：" + m_pointCount.ToString();
            ChartInitial();

            //DataTable Header
            foreach (string name in m_dtColumns)
            {
                m_dt.Columns.Add(name);
            }
            label_DateTime.Text = DateTime.Now.ToString();
            
            timer1.Enabled = true;
        }
        private void button_Open_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_serialPort == null || !m_serialPort.IsOpen)
                {
                    //設定 Serial Port 參數
                    m_serialPort = new SerialPort();
                    m_serialPort.PortName = comboBox_COMPort.Text;
                    m_serialPort.BaudRate = 3000000;
                    m_serialPort.DataBits = 8;
                    m_serialPort.StopBits = StopBits.One;
                    m_serialPort.Parity = Parity.None;
                    m_serialPort.Open();

                    //設定 Modbus 參數
                    m_master = ModbusSerialMaster.CreateRtu(m_serialPort);
                    m_master.Transport.Retries = 3;
                    m_master.Transport.ReadTimeout = 1500;
                    m_master.Transport.WriteTimeout = 1500;
                    m_master.Transport.WaitToRetryMilliseconds = 100;
                    m_master.Transport.LatencyTimer = 1; //需要用最高管理員程式執行才會生效

                    m_master.WriteSingleRegister(m_slaveid, 0x01, m_sampleRate); //設定取樣率為7812
                    m_master.StartFIFO(m_slaveid, m_sampleRate);  //使用GetFIFO_OneSecond_BlockingData方法前，需呼叫StartFIFO(slaveid,sampleRate)方法

                    m_receive_startSR = true;
                    m_ReceiveSerialPort = new Thread(FuncThread_ReceiveMB);
                    m_ReceiveSerialPort.Priority = ThreadPriority.Highest;
                    m_ReceiveSerialPort.IsBackground = true;
                    m_ReceiveSerialPort.Start();

                    button_Export.Enabled = false;
                    button_Open.Text = "Close";

                    //Log紀錄開始量測時間
                    textBox_showMessage(LogLevel.Info, String.Format("Start Measurement"), true);
                }
                else
                {                  
                    button_Export.Enabled = chart_X.Series[0].Points.Count > 0 ? true : false;
                    m_receive_startSR = false;
                    button_Open.Text = "Open";
                    m_secOverFlowCount = 0;
                    m_isNullCount = 0;
                    //0x01，Sample rate change Register Address
                    m_master.WriteSingleRegister(m_slaveid, 0x01, 0);   //設定取樣率為0
                    m_master.Stop();
                    m_master.Dispose();
                    m_master = null;
                    if (m_serialPort.IsOpen)
                    {
                        m_serialPort.DiscardInBuffer();
                        m_serialPort.DiscardOutBuffer();
                        m_serialPort.Close();
                    }

                    //Log紀錄結束量測時間
                    textBox_showMessage(LogLevel.Info, String.Format("End Measurement"), true);
                }
            }
            catch (Exception ex)
            {
                textBox_showMessage(LogLevel.Error, ex.Message, true);
            }
        }
        private void FuncThread_ReceiveMB(object obj)
        {
            ushort[,] FIFO_null = null;
            try
            {
                bool initial = false ;
                Thread.Sleep(10);
                double costSec = 0;
                DateTime endDateTime = DateTime.MinValue;             
                while (m_receive_startSR && m_master != null)
                {                                                     
                    FIFO_null = m_master.GetFIFO_OneSecond_BlockingData(m_pointCount); //當資料長度不足時，會等待讀取資料完成後回傳陣列
                    costSec = DateTime.Now.Subtract(endDateTime).TotalSeconds;
                    endDateTime = DateTime.Now;

                    if (FIFO_null != null)
                    {                       
                        //擷取資料時間 = (1 / SampleRate) * 顯示長度 
                        if (costSec > ((1 / (double)m_sampleRate) * (double)m_pointCount) * 1.02 && initial)
                        {    
                            //擷取時間太長則記錄在Log中
                            textBox_showMessage(LogLevel.Error, String.Format("Retrieve time:{0}", costSec), true);
                            m_secOverFlowCount++;
                        }
                        DrawUI(FIFO_null);                       
                    }
                    else
                    {
                        //紀錄RVT無資料
                        textBox_showMessage(LogLevel.Error, String.Format("Data is null"), true);
                        m_isNullCount++;
                    }
                    textBox_showMessage(LogLevel.Info, String.Format("Retrieve time:{0}", costSec), false); //顯示每次擷取資料時間
                    initial = true;
                }
            }
            catch (Exception ex)
            {
                m_receive_startSR = false;
                textBox_showMessage(LogLevel.Error, ex.Message, true);
            }
        }
        private void DrawUI(object data)
        {
            try
            {
                if (this.InvokeRequired) // 若非同執行緒
                {
                    DrawUIShowEvent dele_data = new DrawUIShowEvent(DrawUI);
                    this.Invoke(dele_data, data);
                }
                else // 同執行緒
                {
                    //繪製Chart
                    UpdateRawDataUI((ushort[,])data);
                }
            }
            catch (Exception ex)
            {
                textBox_showMessage(LogLevel.Error, ex.Message, true);
            }
        }     
        private void ChartInitial()
        {
            chart_X.ChartAreas[0].AxisX.Minimum = 0;
            chart_X.ChartAreas[0].AxisX.Maximum = m_pointCount - 1;

            chart_Y.ChartAreas[0].AxisX.Minimum = 0;
            chart_Y.ChartAreas[0].AxisX.Maximum = m_pointCount - 1;

            chart_Z.ChartAreas[0].AxisX.Minimum = 0;
            chart_Z.ChartAreas[0].AxisX.Maximum = m_pointCount - 1;
        }
        private void UpdateRawDataUI(ushort[,] data)
        {
            List<double> xRawDataDouble = new List<double>();
            List<double> yRawDataDouble = new List<double>();
            List<double> zRawDataDouble = new List<double>();

            chart_X.Series[0].Points.Clear();
            chart_Y.Series[0].Points.Clear();
            chart_Z.Series[0].Points.Clear();
         
            for (int i = 0; i < data.GetLength(1); i++)
            {
                //取得Sensor資料為ushort，顯示以及計算前需轉成short
                xRawDataDouble.Add(Convert.ToDouble((short)data[0, i]) / m_sensorRange);
                yRawDataDouble.Add(Convert.ToDouble((short)data[1, i]) / m_sensorRange);
                zRawDataDouble.Add(Convert.ToDouble((short)data[2, i]) / m_sensorRange);

                chart_X.Series[0].Points.AddXY(i, xRawDataDouble[xRawDataDouble.Count-1]);
                chart_Y.Series[0].Points.AddXY(i, yRawDataDouble[yRawDataDouble.Count - 1]);
                chart_Z.Series[0].Points.AddXY(i, zRawDataDouble[zRawDataDouble.Count - 1]);
            }

            double xMax, xMin, yMax, yMin, zMax, zMin;
            xMax = xRawDataDouble.Max();
            xMin = xRawDataDouble.Min();
            yMax = yRawDataDouble.Max();
            yMin = yRawDataDouble.Min();
            zMax = zRawDataDouble.Max();
            zMin = zRawDataDouble.Min();
            chart_X.ChartAreas[0].AxisY.Minimum = xMin;
            chart_X.ChartAreas[0].AxisY.Maximum = xMax;

            chart_Y.ChartAreas[0].AxisY.Minimum = yMin;
            chart_Y.ChartAreas[0].AxisY.Maximum = yMax;

            chart_Z.ChartAreas[0].AxisY.Minimum = zMin;
            chart_Z.ChartAreas[0].AxisY.Maximum = zMax;
        }
        private void textBox_showMessage(LogLevel logLevel, string text, bool isVisble)
        {
            if (this.InvokeRequired) // 若非同執行緒
            {
                this.Invoke(new textShowEevent(textBox_showMessage), logLevel, text, isVisble);
            }
            else // 同執行緒
            {
                //顯示文字訊息
                label_Msg.Text = text;
                if (m_secOverFlowCount != 0)
                    label_OverFlow.Text = m_secOverFlowCount.ToString();
                if (m_isNullCount != 0)
                    label_NullCount.Text = m_isNullCount.ToString();

                if (isVisble)
                {
                    switch (logLevel)
                    {
                        case LogLevel.Debug:
                            m_logger.Debug(text);
                            break;
                        case LogLevel.Error:
                            m_logger.Error(text);
                            break;
                        case LogLevel.Info:
                            m_logger.Info(text);
                            break;
                    }
                }
            }
        }
        private void button_Export_Click(object sender, EventArgs e)
        {
            try
            {
                if (chart_X.Series[0].Points.Count == 0)
                {
                    MessageBox.Show("No data");
                    return;
                }
                m_dt.Rows.Clear();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveFileDialog.FileName = DateTime.Now.ToString("yyyyMMddHHmmss");
                saveFileDialog.DefaultExt = ".csv";
                saveFileDialog.Filter = "csv資料檔 （.csv）| *.csv";

                DialogResult result = saveFileDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(saveFileDialog.FileName))
                {
                    for (int i = 0; i < m_pointCount; i++)
                    {
                        m_dt.Rows.Add(chart_X.Series[0].Points[i].YValues[0], chart_Y.Series[0].Points[i].YValues[0], chart_Z.Series[0].Points[i].YValues[0]);
                    }
                    Encoding encoding = Encoding.UTF8;
                    exportDataAsCsvString(m_dt, saveFileDialog.FileName, encoding);
                    MessageBox.Show("Export success");
                }
            }
            catch (Exception ex)
            {
                textBox_showMessage(LogLevel.Error, ex.Message, true);
            }
        }
        private void exportDataAsCsvString(DataTable dataTable, string exportFile, Encoding encoding, bool writeHead = true)
        {
            StringBuilder sb = new StringBuilder();

            if (writeHead)
            {
                List<string> headers = new List<string>();
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    DataColumn column = dataTable.Columns[i];
                    headers.Add(column.ColumnName);
                }
                sb.AppendLine(string.Join(",", headers.ToArray()));
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                var s = string.Join(",", row.ItemArray);
                sb.AppendLine(s.ToString());
            }
            System.IO.File.WriteAllText(exportFile, sb.ToString(), encoding);
        }     
        private void timer1_Tick(object sender, EventArgs e)
        {
            label_DateTime.Text = DateTime.Now.ToString();
        }      
    }
}
