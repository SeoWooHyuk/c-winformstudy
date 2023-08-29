using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 도리도리강좌.ucPannel
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int[] test = { 10, 5, 30, 40, 50, 22, 18 };

            label2.Text = "전체 자료수 :" + test.Length;
            for (int i = 0; i < test.Length; i++)
            {

                dataGridView1["Column" + (i + 1), 0].Value = test[i];

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int[,] test = { { 10, 5, 30, 40, 50, 22, 18 }, { 15, 22, 30, 40, 50, 60, 70 } };
            dataGridView1.Rows.Add(test.GetLength(0).ToString());


            label2.Text = "전체 자료수 :" + test.Length;

            for (int i = 0; i < test.GetLength(0); i++)
            {
                for (int j = 0; j < test.GetLength(1); j++)
                {

                    dataGridView1["Column" + (j + 1), i].Value = test[i, j];
                }

            }
        }
    }
}
