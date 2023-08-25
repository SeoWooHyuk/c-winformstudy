using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 도리도리강좌.ucPannel
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            else
            {
                textBox3.Text = Convert.ToString(int.Parse(textBox1.Text), 2); //2변환
                textBox4.Text = Convert.ToString(int.Parse(textBox1.Text), 8); //2변환
                textBox5.Text = Convert.ToString(int.Parse(textBox1.Text), 16); //2변환

            }

        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) //쉬프트연산자 <<
        {

            int iresult = 0;
            int itemp = 0;
            int inumber = 0;

            string inumberstr = Regex.Replace(shiftbox.Text, @"[^0-9]", "");
            if (inumberstr.Equals(""))
            {
                shiftbox.Text = "1";
            }

            if (inumberstr != "")
            {
                itemp = int.Parse(textBox1.Text);
                inumber = int.Parse(inumberstr);
            }

            iresult = itemp << inumber;

            if (iresult == 0)
            {
                iresult = 1;
            }
            textBox1.Text = iresult.ToString();
        }

        private void button2_Click(object sender, EventArgs e) //쉬프트연산자 >>
        {
            int iresult = 1;
            int itemp = 0;
            int inumber = 0;

            string inumberstr = Regex.Replace(shiftbox.Text, @"[^0-9]", "");
            if (inumberstr.Equals(""))
            {
                shiftbox.Text = "1";
            }


            if (inumberstr != "")
            {
                itemp = int.Parse(textBox1.Text);
                inumber = int.Parse(inumberstr);
            }

            iresult = itemp >> inumber;


            if (iresult == 0)
            {
                iresult = 1;
            }
            textBox1.Text = iresult.ToString();
        }

        private void shiftbox_TextChanged(object sender, EventArgs e) //실시간 숫자가아닌값은 못들어오게 처리
        {
            string inumberstr = Regex.Replace(shiftbox.Text, @"[^0-9]", "");
            shiftbox.Text = inumberstr;
        }


    }
}
