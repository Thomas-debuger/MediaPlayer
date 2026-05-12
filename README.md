請直接點擊程式碼區塊右上角的「複製」按鈕，然後貼到你的 GitHub `README.md` 檔案中：

# Media Player 影音播放器 🎬

這是一個使用 C# Windows Forms 開發的簡易影音播放軟體。透過整合 Windows 內建的 Windows Media Player 控制項，讓使用者可以輕鬆載入並控制多種常見的影片與音訊格式。

## 🌟 功能特色 (Features)

* **📂 支援多種格式:** 內建檔案篩選器，支援開啟 `.wmv`、`.mp4`、`.avi` 等常見影音檔案，並提供「所有檔案」選項以增加相容性。
* **▶️ 基礎播放控制:** 提供直覺的「播放 (Play)」、「暫停 (Pause)」與「停止 (Stop)」按鈕。
* **🧠 智慧防呆設計:** 程式啟動時，播放控制按鈕預設為停用狀態。只有在使用者成功載入影音檔案後，系統才會自動啟用對應的控制按鈕，避免誤觸引發錯誤。
* **自動重置:** 載入新影片時，系統會先自動停止當前播放的狀態，確保新檔案能順利初始化。

## 🛠️ 開發環境與技術 (Tech Stack)

* **程式語言:** C#
* **應用程式框架:** Windows Forms (.NET)
* **核心控制項:** Windows Media Player COM Control (`AxWMPLib.AxWindowsMediaPlayer`)
* **開發工具:** Visual Studio 2022

## 📸 執行畫面 (Screenshots)

> 💡 **操作提示：** 請將程式執行時的截圖命名為 `screenshot.png`，並上傳至此 GitHub 專案的根目錄中，圖片就會自動顯示在下方。

![MediaPlayer 執行畫面](./screenshot.png)

## 🚀 執行與編譯說明 (Getting Started)

### 先決條件
請確保您的電腦已安裝 [Visual Studio 2022](https://visualstudio.microsoft.com/zh-hant/vs/)，並包含「.NET 桌面開發」工作負載。
> **注意：** 由於此專案依賴 Windows Media Player 控制項，您的作業系統需具備 Windows Media Player 核心元件。

### 執行步驟
1. 複製此專案到本地端：
   ```bash
   git clone [https://github.com/Thomas-debuger/MediaPlayer.git](https://github.com/Thomas-debuger/MediaPlayer.git)
   ```
2. 進入專案資料夾，對著 `MediaPlayer.sln` 方案檔點擊兩下，以 Visual Studio 開啟專案。
3. 在 Visual Studio 中，按下鍵盤上的 `F5` 鍵，或點擊上方工具列的 **[啟動]** 按鈕。
4. 程式執行後：
* 點擊 **[瀏覽]** 選擇電腦中的影音檔案。
* 檔案載入後，下方按鈕會亮起。
* 點擊對應按鈕進行 **播放**、**暫停** 或 **停止**。



## 📂 核心程式碼架構

本專案主要透過呼叫 `wmpVideo.Ctlcontrols` 介面來實現影音播放的邏輯控制：

```csharp
// 載入檔案與初始化
wmpVideo.URL = ofd.FileName;
wmpVideo.Ctlcontrols.stop(); 

// 播放控制
wmpVideo.Ctlcontrols.play();  // 播放
wmpVideo.Ctlcontrols.pause(); // 暫停
wmpVideo.Ctlcontrols.stop();  // 停止

```
