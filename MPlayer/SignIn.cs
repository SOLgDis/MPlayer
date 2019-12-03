using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPlayer
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp su = new SignUp();
            su.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        string login;
            string pass;
        private void button1_Click(object sender, EventArgs e)
        {
            login = "login";
            pass = "pass";
            if(checkBox1.CheckState == CheckState.Indeterminate)
            {
                if(textBox1.Text==login && textBox2.Text== pass)
                {
                    this.Hide();
                    MPlayer mp = new MPlayer();
                    mp.Show();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
        }
        private   void checkBox1_Click(object sender, EventArgs e)
        {

            if (checkBox1.CheckState == CheckState.Checked)
            {
                this.Hide();
                Captcha cp = new Captcha();
                cp.Show();
            }
                
        }
    }
}
