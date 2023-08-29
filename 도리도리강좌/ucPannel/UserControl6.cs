using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 도리도리강좌.ucPannel.classsusc6;

namespace 도리도리강좌.ucPannel
{
    public partial class UserControl6 : UserControl
    {

        XmlControl _xml = new XmlControl();

        Dictionary<string, string> _dData = new Dictionary<string, string>();


        public UserControl6()
        {
            InitializeComponent();
        }



        //설정 가져오기 
        private void button3_Click(object sender, EventArgs e)
        {
            string[] strconfig = textBox1.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            textBox2.Text = strconfig[0];
            checkBox1.Checked = bool.Parse(strconfig[1]);
            numericUpDown1.Value = int.Parse(strconfig[2]);
        }

        //설정하기
        private void button4_Click(object sender, EventArgs e)
        {
            string strenter = "\r\n";

            string strtext = textBox2.Text;
            bool bcheck = checkBox1.Checked;
            int inumber = (int)numericUpDown1.Value;
            StringBuilder sb = new StringBuilder();
            sb.Append(strtext + strenter);
            sb.Append(bcheck.ToString() + strenter);
            sb.Append(inumber.ToString() + strenter);

            textBox1.Text = sb.ToString();
        }

        //텍스트파일읽어오기
        private void button1_Click(object sender, EventArgs e)
        {
            string strfilepath = string.Empty;
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.InitialDirectory = Application.StartupPath; //프로그램 실행파일 위치
            openFileDialog1.FileName = ".txt";
            openFileDialog1.Filter = "*.txt files (*.txt)|*.txt|All files (*.*)|*.*";

            StringBuilder sb = new StringBuilder();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strfilepath = openFileDialog1.FileName;
                StreamReader dreader = new StreamReader(strfilepath, Encoding.UTF8, true);
                while (dreader.EndOfStream == false) //dreader.EndOfStream 읽은줄이 마지막이아니면 계속 TRUE 마지막이면 FALSE
                {
                    sb.Append(dreader.ReadLine() + "\r\n");
                }

                textBox1.Text = sb.ToString();
            }
        }

        //텍스트파일 저장하기
        private void button2_Click(object sender, EventArgs e)
        {
            string strfilepath = string.Empty;

            saveFileDialog1.InitialDirectory = Application.StartupPath; //프로그램 실행파일 위치
            saveFileDialog1.FileName = ".txt";
            saveFileDialog1.Filter = "*.txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("읽었나");
                strfilepath = saveFileDialog1.FileName;
                StreamWriter dsave = new StreamWriter(strfilepath);
                dsave.WriteLine(textBox1.Text);
                dsave.Close();
            }
        }



        //xml읽은값 가져오기
        private void xmlbt3_Click(object sender, EventArgs e)
        {
            textBox4.Text = _dData[XmlControl._TEXT_DATA];
            checkBox2.Checked = bool.Parse(_dData[XmlControl._CBOX_DATA]);
            numericUpDown2.Value = int.Parse(_dData[XmlControl._NUMBER_DATA]);
        }

        //xml설정하기
        private void xmlbt4_Click(object sender, EventArgs e)
        {
            string strenter = "\r\n";

            string strtext = textBox4.Text;
            bool bcheck = checkBox2.Checked;
            int inumber = (int)numericUpDown2.Value;
            StringBuilder sb = new StringBuilder();
            sb.Append(strtext + strenter);
            sb.Append(bcheck.ToString() + strenter);
            sb.Append(inumber.ToString() + strenter);

            textBox3.Text = sb.ToString();

            _dData.Clear();

            _dData.Add(XmlControl._TEXT_DATA, strtext);
            _dData.Add(XmlControl._CBOX_DATA, bcheck.ToString());
            _dData.Add(XmlControl._NUMBER_DATA, inumber.ToString());
        }

        //xml파일 저장하기
        private void xmlbt2_Click(object sender, EventArgs e)
        {
            string strfilepath = string.Empty;

            saveFileDialog1.InitialDirectory = Application.StartupPath; //프로그램 실행파일 위치
            saveFileDialog1.FileName = ".xml";
            saveFileDialog1.Filter = "*.xml files (*.xml)|*.xml|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strfilepath = saveFileDialog1.FileName;
                _xml.fxml_write(strfilepath, _dData);
            }
        }

        //xml파일 읽어오기
        private void xmlbt1_Click(object sender, EventArgs e)
        {
            string strfilepath = string.Empty;

            openFileDialog1.InitialDirectory = Application.StartupPath; //프로그램 실행파일 위치
            openFileDialog1.FileName = ".xml";
            openFileDialog1.Filter = "*.xml files (*.xml)|*.xml|All files (*.*)|*.*";

            StringBuilder sb = new StringBuilder();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strfilepath = openFileDialog1.FileName;

                Console.WriteLine(strfilepath);

                sb.Append(File.ReadAllText(strfilepath));
                textBox3.Text = sb.ToString();

                _dData.Clear();
                _dData = _xml.fxml_read(strfilepath);

            }
        }


    }
}
