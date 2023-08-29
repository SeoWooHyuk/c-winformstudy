using System;
using System.Collections;
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
    public partial class UserControl9 : UserControl
    {
        List<string> strlist = new List<string>();
        List<int> intlist = new List<int>();

        ArrayList arrayList = new ArrayList();




        public UserControl9()
        {
            InitializeComponent();
           // dataGridView1.Columns.Add("dbvalue", "Value");
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            string selecttext = string.Empty;
            switch (pictureBox.Name)
            {
                case "pictureBox1":

                    selecttext = "치킨";
                    break;

                case "pictureBox2":
                    selecttext = "피자";
                    break;

                case "pictureBox3":
                    selecttext = "짜장면";
                    break;

                case "pictureBox4":
                    selecttext = "짬뽕";
                    break;

                default:break;
                
              


            }

            strlist.Add(selecttext);

            viewdisplay();
            viewDatagried2(); //더간편한방법

        }

        private void viewdisplay()  //데이터 ui
        {
            int chicken = 0;
            int pizza = 0;
            int zazang = 0;
            int zampong = 0;

            foreach (string item in strlist)
            {
                switch (item)
                {
                    case "치킨":
                        chicken++;
                        break;

                    case "피자":
                        pizza++;
                        break;

                    case "짜장면":
                        zazang++;
                        break;

                    case "짬뽕":
                        zampong++;
                        break;
                }

                labelpick1.Text = chicken.ToString();  
                labelpick2.Text = pizza.ToString();
                labelpick3.Text = zazang.ToString();
                labelpick4.Text = zampong.ToString();

                lbtotalcount.Text = strlist.Count.ToString();
            }
        }


        private void viewDatagried()
        { 
            dataGridView1.Rows.Clear();
           

            foreach (var item in strlist)
            {

                 //dataGridView1["Column", 0].Value = test[i];
                dataGridView1.Rows.Add(item);
            }

            foreach (DataGridViewRow orow  in dataGridView1.Rows)
            {
                orow.HeaderCell.Value = orow.Index.ToString();
            }

            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

        }

        //더간편한방법
        private void viewDatagried2()
        {
            dataGridView1.DataSource = strlist.Select(x => new { value = x }).ToList();

            foreach (DataGridViewRow orow in dataGridView1.Rows)
            {
                orow.HeaderCell.Value = orow.Index.ToString();
            }

            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

        }


    }
}
