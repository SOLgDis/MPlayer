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
    public partial class Forgoted : Form
    {
        public Forgoted()
        {
            InitializeComponent();
        }
 SignIn si = new SignIn();
        private void Forgoted_Load(object sender, EventArgs e)
        {
           
            label1.Text = si.secretQuest;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text !="" && textBox2.Text !="")
            {
                if (textBox1.Text == si.secretAnsw && textBox2.Text == si.birthdat)
                    MessageBox.Show($"Ваш пароль {si.pass}");
                else
                    MessageBox.Show($"Неверно. Убедитесь что правильно ввели данные!");
            }

        }
    }
}
