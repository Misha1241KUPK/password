using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пароль
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if ((s.Length >= 6 && s.Any(char.IsUpper) && s.Any(char.IsDigit) &&
               s.IndexOfAny(new char[] { '!', '@', '#', '$', '%', '^' }) >= 0))
            {
                MessageBox.Show("Прверка прошла успешно");
                Application.Exit();
            }
            else if (s.Length < 6)
            {
                MessageBox.Show("В пароле необходимо минимум 6 символов");
            }
            else if (s.Any(char.IsUpper) == false)
            {
                MessageBox.Show("В пароле нужна минимум 1 прописная буква");
            }
            else if (s.Any(char.IsDigit) == false)
            {
                MessageBox.Show("В пароле нужна минимум 1 цифра");
            }
            else if (s.IndexOfAny(new char[] { '!', '@', '#', '$', '%', '^' }) < 0)
            {
                MessageBox.Show("В пароле нужен минимум один символ из набора: ! @ # $ % ^");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Минимум 6 символов. \n-Минимум 1 прописная буква." +
                " \n-Минимум 1 цифра. \n-Минимум один символ из набора: ! @ # $ % ^ ", "Условия пароля");
        }
    }
}
