using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Генератор_Паролей
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len_pass = (int)numericUpDown1.Value;
            int quantily = (int)numericUpDown2.Value;
            bool symbols = checkBox1.Checked;
            bool symbols1 = checkBox2.Checked;
            Random rand = new Random();
            Random type = new Random();

            string specialChars = "!@#$%^&*()-=_+[]{}|;:'\",.<>?";
            char[] allChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
            int[] digitArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int j = 0; j < quantily; j++)
            {
                for (int i = 0; i < len_pass; i++)
                {
                    int type_num = type.Next(0, 2);
                    char value;

                    if (type_num == 0)
                    {
                        if (symbols)
                        {
                            value = allChars[rand.Next(0, allChars.Length)];
                        }
                        else
                        {
                            value = digitArray[rand.Next(0, digitArray.Length)].ToString()[0];
                        }
                    }
                    else
                    {
                        if (symbols1)
                        {
                            value = specialChars[rand.Next(0, specialChars.Length)];
                        }
                        else
                        {
                            i--; 
                            continue;
                        }
                    }

                    richTextBox1.AppendText(value.ToString());
                }
                richTextBox1.AppendText("\n");
            }
        }
    }
}
