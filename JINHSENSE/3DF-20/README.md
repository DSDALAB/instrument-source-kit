# 3DF-20 設備基礎程式

## 簡介
本專案提供針對 3DF-20 設備的基礎程式碼，旨在協助使用者快速上手並進行基本操作。該設備由 [JIHSENSE 龍鳳科技有限公司](https://jihsense-loadcell.com/product_cht.asp?pid=38) 生產，主要用於負載測量。

## 目錄結構
```
src/
    ├── 3DF-20_Format (subVI).vi  # 格式化子VI
    ├── 3DF-20_Read.vi             # 讀取數據的主VI
    ├── 3DF.aliases                 # 別名設定
    ├── 3DF.lvlps                   # LVLPS 設定檔
    └── 3DF.lvproj                  # LabVIEW 專案檔
```

## 使用說明
1. **3DF-20_Format (subVI).vi**: 此子VI用於格式化輸入數據，確保數據的正確性和一致性。
2. **3DF-20_Read.vi**: 主VI，負責從設備讀取數據並進行處理。
3. **3DF.aliases**: 包含設備的別名設定，方便在程式中引用。
4. **3DF.lvlps**: 設定檔，包含設備的配置參數。
5. **3DF.lvproj**: LabVIEW 專案檔，整合所有相關VI。

## 安裝與配置
請確保已安裝 LabVIEW 環境，並將所有檔案放置於同一專案資料夾中。打開 `3DF.lvproj` 以開始使用。

## 參考
如需更多資訊，請參考 [3DF-20 設備官方網站](https://jihsense-loadcell.com/product_cht.asp?pid=38)。
