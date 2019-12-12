using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPlayer
{
    public partial class MPlayer : Form
    {
        List<string> playlist = new List<string>();
        public MPlayer()
        {
            InitializeComponent();
        }
        SoundPlayer sp = new SoundPlayer("1.wav");
        private void MPlayer_Load(object sender, EventArgs e)
        {
            playlist.AddRange(File.ReadAllLines("playlist.txt"));
            axWindowsMediaPlayer1.URL = $@"playlist\{playlist[m]}";
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Visible = false;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            m++;
            axWindowsMediaPlayer1.URL = $@"playlist\{playlist[m]}";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        int m = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //не работает, придумать как исправить

            
            axWindowsMediaPlayer1.Ctlcontrols.play();
            MessageBox.Show(playlist[m]);                   
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Browser br = new Browser();
            br.Show();
        }
    }
}
