using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class frmMediaPlayer : Form
    {
        public frmMediaPlayer()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "WMV files (*.wmv)|*.wmv|MP4files(*.mp4) | *.mp4 | AVI files(*.avi) | *.avi | All files(*.*) | *.* ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                wmpVideo.URL = ofd.FileName;
                wmpVideo.Ctlcontrols.stop(); // 停止

                this.btnPlay.Enabled = true;
                this.btnPause.Enabled = true;
                this.btnStop.Enabled = true;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.play(); // 播放
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.pause(); // 暫停
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.stop(); // 停止
        }
    }
}
