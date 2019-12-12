using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            this.Hide();
            Forgoted ft = new Forgoted();
            ft.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            if(checkBox1.CheckState == CheckState.Indeterminate)
            {
                for (int i = 0; i < logins.Length; i++)
                    if (textBox1.Text == logins[i])
                    { 
                        login = logins[i];
                        ilogin = i;
                    }
                if(textBox2.Text == passs[ilogin])
                {
                    this.Hide();
                    Captcha cp = new Captcha();
                    cp.Close();
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
          
        }
        public string login;
        public string pass;
        public string secretQuest ;
        public string secretAnsw ;
        public string birthdat;
        public string[] logins;
        public string[] passs;
        public string[] secretQuests;
        public string[] secretAnsws;
        public string[] birthdats;
        public int ilogin;
        private void SignIn_Load(object sender, EventArgs e)
        {
            logins = File.ReadAllLines("Login.txt");
            passs = File.ReadAllLines("Password.txt");
            secretQuests = File.ReadAllLines("SecretQuestion.txt");
            secretAnsws = File.ReadAllLines("SecretAnswer.txt");
            birthdats = File.ReadAllLines("Birthdate.txt");
        }

        private void checkBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void checkBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState != CheckState.Checked && checkBox1.CheckState != CheckState.Indeterminate)
            {
                this.Hide();
                Captcha cp = new Captcha();
                cp.Show();
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
