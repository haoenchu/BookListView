# BookListView - 圖書管理系統

這是一個基於 C# Windows Forms 開發的圖書管理應用程式，主要展示 `ListView` 控制項的多種檢視切換與進階資料處理功能。
<img width="846" height="436" alt="image" src="https://github.com/user-attachments/assets/62d172aa-c9b1-4ac9-af3b-7db4ffd51207" />



## 核心功能

* **多樣化檢視切換**：支援大圖示 (LargeIcon)、詳細資料 (Details)、小圖示 (SmallIcon)、清單 (List) 及大圖示加詳細資料 (Tile) 等五種顯示模式。
* **動態資料載入**：在表單載入時，自動從陣列匯入書籍名稱、作者與類別資料。
* **借閱與日期管理**：
    * **雙擊借閱**：使用者可透過快按兩下項目觸發 `ItemActivate` 事件進行借閱。
    * **日期計算**：整合 `DateTimePicker` 紀錄借閱日期，並自動計算 7 天的借閱期限。
    * **衝突檢查**：借閱時系統會檢查該書名在選定日期區間內是否已被借閱，避免重複借書。
  <div align=center>
    <img width=40% height="312" alt="image" src="https://github.com/user-attachments/assets/9d3f9bdf-62be-476e-a84f-94d7eab7dabd" />
    <img width=40% height="345" alt="image" src="https://github.com/user-attachments/assets/4a247cb7-a61a-4967-8ff2-af4ffb1407a4" />
  </div>
   
* **歸還功能**：在「借書清單」中雙擊項目即可執行歸還，並附帶二次確認視窗以防誤點。
<div align=center>
   <img width="354" height="264" alt="image" src="https://github.com/user-attachments/assets/93defb93-0935-4682-b3c3-f91bf158d095" />
</div>


## 技術重點

* **ListView 控制項應用**：
    * **欄位管理**：使用 `Columns.Add` 動態建立多欄位表單 (如書名、作者、到期日)。
    * **資料結構**：利用 `ListViewItem` 與 `SubItems` 建立階層式資料結構。
    * **效能優化**：利用 `BeginUpdate` 與 `EndUpdate` 方法，在大量更新資料時停止控制項重繪，避免螢幕閃動。
* **事件驅動設計**：
    * `ItemActivate`：處理書籍的借閱啟動邏輯。
    * `SelectedIndexChanged`：即時連動 `ComboBox` 切換 `ListView.View` 屬性。

## 開發環境

* **語言**：C#
* **框架**：.NET Framework / Windows Forms
* **開發工具**：Visual Studio

---
*本專案為視窗程式設計課程之實驗成果。*
