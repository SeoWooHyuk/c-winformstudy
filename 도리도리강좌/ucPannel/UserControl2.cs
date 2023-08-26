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

namespace 도리도리강좌.ucPannel
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private enum enumDay
        {
            월,
            화,
            수,
            목,
            금,
            토,
            일,

        }

        private enum enumTime
        {
            아침,
            점심,
            저녁,

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

            foreach (enumDay item in Enum.GetValues(typeof(enumDay)))
            {
                listBoxDay.Items.Add(item);
            }


            listBoxTime.Items.Add(enumTime.아침);
            listBoxTime.Items.Add(enumTime.점심);
            listBoxTime.Items.Add(enumTime.저녁);
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
           
            string str =  textBoxname.Text + "와" + listBoxDay.SelectedItem.ToString() + " 요일 " + listBoxTime.SelectedItem.ToString() + "먹기로 했습니다" ;
            tboxResult.Text = str;         
        }

        private void buttonResult2_Click(object sender, EventArgs e)
        {
            
            string str = string.Format("{0} 와 {1} 요일 {2} 먹기로했습니다",textBoxname.Text , listBoxDay.SelectedItem.ToString(), listBoxTime.SelectedItem.ToString() );
            tboxResult.Text += str;
        }

       
    }
}
