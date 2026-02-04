# DSDALab Equipment Control & Utilities

本倉庫存放實驗室常用設備的基礎控制程式碼、驅動函式庫及測試工具。
倉庫中的檔案、程式碼可能來自於廠商，若有不適，請來信通知下架。

## 專案結構 (Project Structure)

本專案依照「廠商 (Manufacturer)」>「設備型號 (Model)」的層級進行分類：

## 設備清單與詳細資訊

### 1. Jihsense 3DF-20 Load Cell

* **廠商**：Jihsense (煜昕科技有限公司)
* **型號**：JS-118-2 (LM Type Load Cell)
* **類型**：低外型荷重元 (Low Profile Load Cell)
* **描述**：
  該目錄包含用於讀取 JS-118-2 荷重元訊號的程式碼。此設備具備高精度與低高度特性，適用於力量量測與自動控制系統。
* **主要規格**：
  * **量測方向**：雙向 (拉力/壓力)
  * **特點**：全密封保護、抗側向力、高剛性底座
* **目錄內容**：
  * 訊號轉換與校正 (Calibration) 相關腳本
  * 數據讀取範例 (透過 DAQ 或顯示儀表)

### 2. Broadsound 6006PR Ultrasonic Pulser/Receiver

* **廠商**：Broadsound Corporation (廣聲科技) / Baugh & Weedon
* **型號**：6006PR / 6006PR PLUS
* **類型**：超音波脈衝發射/接收器 (Ultrasonic Pulser/Receiver)
* **描述**：
  本目錄提供控制 6006PR 的介面程式與參數設定檔。此設備用於超音波非破壞檢測 (NDT)，支援 Pulse-Echo (脈衝回波) 與 Through-Transmission (穿透) 模式。
* **主要規格**：
  * **頻寬**：0.5 MHz - 35 MHz
  * **介面**：USB 2.0 (用於參數控制)
  * **功能**：可調整增益 (Gain)、濾波器、脈衝能量與阻尼。
* **目錄內容**：
  * USB 控制介面函式庫
  * 參數自動化設定腳本
  * 波形擷取範例

### 3. NI (National Instruments)

* **廠商**：National Instruments
* **類型**：DAQ (Data Acquisition) 資料擷取
* **描述**：
  包含實驗室 NI DAQ 設備的通用控制程式，主要用於類比訊號 (如 Load Cell 電壓) 的數位化採集。
* **目錄內容**：
  * `nidaqmx` (Python) 或 LabVIEW 範例程式
  * 類比輸入 (Analog Input) 設定檔
  * 觸發 (Trigger) 與同步採集設定

---

## 快速開始 (Getting Started)

### 前置需求 (Prerequisites)

    請根據程式碼安裝對應的開發環境， LabVIEW 2018、Python、MATLAB

### 使用方式

請參考各設備子目錄下的 `README.md` 或範例檔案 (Examples) 進行連線測試。

---

## 貢獻 (Contributing)

歡迎實驗室成員提交 Pull Request 更新設備驅動或新增功能。提交前請確保程式碼包含適當的註解。

---

---

## 免責聲明與版權注意事項 (Disclaimer & Copyright Notice)

1. **程式碼來源 (Source Code Origin)**：
   本倉庫部分程式碼、API 定義或驅動函式庫參考自設備製造商（Jihsense, Broadsound, National Instruments 等）所提供之範例文件或 SDK。這些特定內容的智慧財產權歸原廠商所有。

2. **下架通知 (Takedown Policy)**：
   本專案旨在學術研究與實驗室內部設備整合紀錄。**倉庫中的檔案、程式碼可能部分來自於廠商公開或提供之資料，若相關廠商認為內容不適宜公開或涉及版權疑慮，請來信通知，我們將會在收到通知後立即移除相關檔案。**

3. **使用風險 (Usage Risk)**：
   本倉庫提供的程式碼僅供參考與學術交流。使用者在操作實體設備（如 Load Cell, High Voltage Pulser）時，請務必詳閱硬體手冊並自行承擔風險。本實驗室不對因使用本倉庫程式碼而導致的任何硬體損壞或數據遺失負責。

## 聯絡我們 (Contact)
如有任何版權問題或建議，請聯繫：[nkfustdsda@gmail.com]