# BS6006PRPLUS 設備基礎程式

## 簡介
本專案提供針對 Broadsound BS6006PRPLUS 設備的基礎程式碼與開發 API，旨在協助使用者快速上手並進行基本操作與開發。

## 系統需求
**重要：開發 6006PR 需要使用 LabVIEW 32bit 環境**

## 目錄結構

### BS6006PRPLUS_DLL/
LabVIEW 開發 API（僅支援 32bit 環境），提供完整的設備控制功能。

```
BS6006PRPLUS_DLL/
├── BS6006PRPLUS_DLL.lvlib     # LabVIEW 函式庫
├── Example.vi                  # 範例程式
└── VIs/                        # API 子 VI 集合
    ├── PR Check Device Connected.vi      # 檢查設備連接狀態
    ├── PR Check General Power.vi         # 檢查一般電源
    ├── PR Check Voltage Of Pulser.vi     # 檢查脈衝發生器電壓
    ├── PR Connect Device.vi              # 連接設備
    ├── PR Current No Acq Signal.vi       # 取得當前訊號採集數量
    ├── PR Current PRF.vi                 # 取得當前 PRF（脈衝重複頻率）
    ├── PR Current Pulse Index.vi         # 取得當前脈衝索引
    ├── PR Current Receiver Gain.vi       # 取得當前接收增益
    ├── PR Current Sampling Frequency.vi  # 取得當前採樣頻率
    ├── PR Current Trigger Delay.vi       # 取得當前觸發延遲
    ├── PR Current Trigger Source.vi      # 取得當前觸發源
    ├── PR Enable Acquire Signal.vi       # 啟用訊號採集
    ├── PR Error Code.vi                  # 錯誤代碼處理
    ├── PR Get Length Of Signal Setting.vi    # 取得訊號長度設定
    ├── PR Get No Acq Signal Setting.vi       # 取得訊號採集數量設定
    ├── PR Led Action.vi                  # LED 控制
    ├── PR Run And Acquire Signal.vi      # 執行並採集訊號
    ├── PR Run.vi                         # 執行設備
    ├── PR Serial Number.vi               # 取得序號
    ├── PR Set Length Of Signal.vi        # 設定訊號長度
    ├── PR Set No Acq Signal.vi           # 設定訊號採集數量
    ├── PR Set PRF.vi                     # 設定 PRF（脈衝重複頻率）
    ├── PR Set Pulse.vi                   # 設定脈衝參數
    ├── PR Set Receiver Gain.vi           # 設定接收增益
    ├── PR Set Sampling Frequency.vi      # 設定採樣頻率
    ├── PR Set Time Out.vi                # 設定逾時時間
    ├── PR Set Trigger Delay.vi           # 設定觸發延遲
    ├── PR Set Trigger Source.vi          # 設定觸發源
    ├── PR Stop.vi                        # 停止設備
    ├── PR Switch To Pulse Echo Mode.vi   # 切換至脈衝回波模式
    └── PR Switch To Thru Mode.vi         # 切換至直通模式
```

### src/
測試用的 LabVIEW 程式，提供開發與測試參考範例。

```
src/
├── LV_6006PR.lvproj            # LabVIEW 專案檔
├── LV_6006PR.aliases           # 別名設定
├── LV_6006PR.lvlps             # LVLPS 設定檔
├── API/
│   └── BS6006PRPLUS_DLL.h      # C/C++ 標頭檔
└── VIs/
    ├── CheckTest.vi                      # 檢查測試 VI
    ├── Pulse_Parameters.ctl              # 脈衝參數控制項
    └── TriggerSource_Parameters.ctl      # 觸發源參數控制項
```

## 主要功能

### 設備控制
- 設備連接與狀態檢查
- 電源與電壓監控
- LED 指示燈控制
- 序號讀取

### 訊號採集
- 啟用/停止訊號採集
- 設定採樣頻率
- 設定訊號長度與採集數量
- 執行並採集訊號

### 脈衝控制
- 設定脈衝參數
- 設定 PRF（脈衝重複頻率）
- 切換脈衝回波模式與直通模式
- 脈衝索引管理

### 觸發設定
- 設定觸發源
- 設定觸發延遲
- 查詢當前觸發設定

### 接收器設定
- 設定接收增益
- 查詢當前接收器狀態

## 快速開始

1. **安裝 LabVIEW 32bit**：確保已安裝 LabVIEW 32bit 版本（不支援 64bit）

2. **載入專案**：
   - 開啟 `src/LV_6006PR.lvproj` 以使用測試程式
   - 或參考 `BS6006PRPLUS_DLL/Example.vi` 開始開發

3. **連接設備**：
   - 使用 `PR Connect Device.vi` 建立設備連接
   - 使用 `PR Check Device Connected.vi` 確認連接狀態

4. **基本操作流程**：
   ```
   連接設備 → 設定參數 → 啟用訊號採集 → 執行並採集 → 處理數據 → 停止設備
   ```

## API 使用說明

### 初始化流程
1. 呼叫 `PR Connect Device.vi` 連接設備
2. 使用 `PR Check Device Connected.vi` 驗證連接
3. 使用 `PR Serial Number.vi` 讀取設備序號

### 訊號採集流程
1. 使用 `PR Set Sampling Frequency.vi` 設定採樣頻率
2. 使用 `PR Set Length Of Signal.vi` 設定訊號長度
3. 使用 `PR Set No Acq Signal.vi` 設定採集數量
4. 使用 `PR Enable Acquire Signal.vi` 啟用訊號採集
5. 使用 `PR Run And Acquire Signal.vi` 執行並採集訊號
6. 使用 `PR Stop.vi` 停止採集

### 錯誤處理
所有 API 皆包含錯誤輸出，使用 `PR Error Code.vi` 可協助解析錯誤代碼。

## 注意事項

1. **僅支援 32bit 環境**：本 API 僅能在 LabVIEW 32bit 環境下運行
2. **逾時設定**：建議使用 `PR Set Time Out.vi` 適當設定逾時時間，避免程式無回應
3. **模式切換**：在切換脈衝回波模式與直通模式時，建議先停止設備運行
4. **電源檢查**：執行採集前建議先檢查一般電源與脈衝發生器電壓狀態

## 開發參考

- **Example.vi**：提供完整的使用範例，建議新手從此開始
- **CheckTest.vi**：提供測試程式參考
- **BS6006PRPLUS_DLL.h**：提供 C/C++ 開發者的標頭檔參考

## 技術支援

如需更多技術支援或設備資訊，請聯繫 Broadsound 廠商。