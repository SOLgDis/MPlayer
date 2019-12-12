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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aqua;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                if(textBox2.Text == textBox3.Text)
                { 
                File.AppendAllText("Login.txt",textBox1.Text);
                File.AppendAllText("Password.txt", textBox2.Text);
                File.AppendAllText("SecretQuestion.txt", textBox3.Text);
                File.AppendAllText("SecretAnswer.txt", textBox4.Text);
                File.AppendAllText("Birthdate.txt", textBox5.Text);
                this.Hide();
                SignIn si = new SignIn();
                si.Show();
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
