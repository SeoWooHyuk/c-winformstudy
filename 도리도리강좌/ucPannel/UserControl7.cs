using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 도리도리강좌.ucPannel.classsusc7;

namespace 도리도리강좌.ucPannel
{

    public partial class UserControl7 : UserControl
    {
       
        Dictionary<string, string> _dData = new Dictionary<string, string>();
        string strpath = Application.StartupPath + "\\Save.xml";


        private double itick = 0;
        private double itotal = 0;

        private int i1add = 1;
        private int i1level = 1;

        private int i3add = 0;
        private int i3level = 0;

        private int i50add = 0;
        private int i50level = 0;


        public UserControl7()
        {
            InitializeComponent();
           


        }

        public void usercloseeven()
        {
            XmlControl _xml = new XmlControl();
            _dData.Clear();
            _dData.Add(XmlControl._TICK, itick.ToString());
            _dData.Add(XmlControl._TOTAL, itotal.ToString());
            _dData.Add(XmlControl._LEVEL_1, i1level.ToString());
            _dData.Add(XmlControl._LEVEL_3, i3level.ToString());
            _dData.Add(XmlControl._LEVEL_50, i50level.ToString());
            _xml.fxml_write(strpath , _dData);

       
        }

        

        private void UserControl7_Load(object sender, EventArgs e)
        {

            CRijndeal cRijndeal = new CRijndeal();

            string a = "안녕하세여 ASD QQWEFDFAWGAWGAWGAWGAWGAWGAWGAWGAWGF";
            string test = cRijndeal.encrypted(a);
            string test2 = cRijndeal.roundtrip(test);

            Console.WriteLine(test);
            Console.WriteLine(test2);

            if (File.Exists(strpath)) //파일이있을경우 파일로딩
            {
                XmlControl _xml = new XmlControl();
                _dData = _xml.fxml_read(strpath);

                itick =  double.Parse (_dData[XmlControl._TICK]);
                itotal = double.Parse(_dData[XmlControl._TOTAL]);
                i1level = int.Parse(_dData[XmlControl._LEVEL_1]);
                i3level = int.Parse(_dData[XmlControl._LEVEL_3]);
                i50level = int.Parse(_dData[XmlControl._LEVEL_50]);
            }

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Enabled = true;
            timer.Interval = 100;

            timer.Tick += Timer_Tick;
            timer.Start();

        }

        //타이머에서 호출할이벤트 인터벌 간격기준

        private void Timer_Tick(object? sender, EventArgs e)
        {

            itick = i1add + i3add + i50add;
            itotal = itick + itotal;

            label2.Text = string.Format("{0}(1:{1}), (3:{2}) ,(50:{3})", itick.ToString(), i1level.ToString(), i3level.ToString(), i50level.ToString());

            label1.Text = itotal.ToString();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;



            switch (btn.Name)
            {
                case "button1":
                    if (itotal >= 100)
                    {
                        itotal = itotal - 100;
                        i1level++;
                        i1add = 1 * i1level;
                    }

                    break;
                case "button2":
                    if (itotal >= 500)
                    {
                        itotal = itotal - 500;
                        i3level++;
                        i3add = 3 * i3level;
                    }
                    break;
                case "button3":
                    if (itotal >= 5000)
                    {
                        itotal = itotal - 5000;
                        i50level++;
                        i50add = 50 * i50level;
                    }
                    break;
                default:
                    break;
            }



        }
    }
}
