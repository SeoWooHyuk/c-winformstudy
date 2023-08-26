using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using 도리도리강좌.ucPannel.classsusc5;

namespace 도리도리강좌.ucPannel
{
    public partial class UserControl5 : UserControl
    {

        CData cdata = new CData();

        public UserControl5()
        {
            InitializeComponent();
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {

            foreach (Enumitem item in Enum.GetValues(typeof(Enumitem)))
            {
                comboBox1.Items.Add(item);
            }

            EnumRate[] er = (EnumRate[])Enum.GetValues(typeof(EnumRate));

            foreach (var item in er)
            {
                comboBox2.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            cdata.Stringitem = comboBox1.Text;
            cdata.IRate = (int)Enum.Parse(typeof(Enumitem), comboBox2.Text);
            cdata.ICount = (int)numericUpDown1.Value;

            textBox2.Text = cdata.StringErrName;
            

        }
    }
}
