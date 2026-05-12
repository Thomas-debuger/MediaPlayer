namespace MediaPlayer
{
    partial class frmMediaPlayer
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMediaPlayer));
            this.palButton = new System.Windows.Forms.Panel();
            this.wmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.palButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // palButton
            // 
            this.palButton.Controls.Add(this.btnStop);
            this.palButton.Controls.Add(this.btnPause);
            this.palButton.Controls.Add(this.btnPlay);
            this.palButton.Controls.Add(this.btnBrowser);
            this.palButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.palButton.Location = new System.Drawing.Point(0, 370);
            this.palButton.Name = "palButton";
            this.palButton.Size = new System.Drawing.Size(800, 80);
            this.palButton.TabIndex = 1;
            // 
            // wmpVideo
            // 
            this.wmpVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Location = new System.Drawing.Point(0, 0);
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size = new System.Drawing.Size(800, 450);
            this.wmpVideo.TabIndex = 0;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBrowser.Location = new System.Drawing.Point(21, 18);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(91, 41);
            this.btnBrowser.TabIndex = 0;
            this.btnBrowser.Text = "瀏覽";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlay.Location = new System.Drawing.Point(132, 18);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(91, 41);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "播放";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPause.Location = new System.Drawing.Point(243, 18);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(91, 41);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "暫停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStop.Location = new System.Drawing.Point(354, 18);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(91, 41);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // frmMediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.palButton);
            this.Controls.Add(this.wmpVideo);
            this.Name = "frmMediaPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "多媒體播放器";
            this.palButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private System.Windows.Forms.Panel palButton;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnBrowser;
    }
}

