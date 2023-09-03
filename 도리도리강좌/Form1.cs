namespace 도리도리강좌
{
    public partial class Form1 : Form
    {
        ucPannel.UserControl1 uc1 = new ucPannel.UserControl1(); //연산자 진수
        ucPannel.UserControl2 uc2 = new ucPannel.UserControl2(); //enum
        ucPannel.UserControl3 uc3 = new ucPannel.UserControl3(); //배열
        ucPannel.UserControl4 uc4 = new ucPannel.UserControl4(); //상속및 접근제어 그림그리기
        ucPannel.UserControl5 uc5 = new ucPannel.UserControl5(); //캡슐화
        ucPannel.UserControl6 uc6 = new ucPannel.UserControl6(); //파일입출력
        ucPannel.UserControl7 uc7 = new ucPannel.UserControl7(); //타이머 암호화 복호화
        ucPannel.UserControl8 uc8 = new ucPannel.UserControl8(); //자료구조큐스텍
        ucPannel.UserControl9 uc9 = new ucPannel.UserControl9(); //자료구조리스트
        ucPannel.UserControl10 uc10 = new ucPannel.UserControl10(); //자료구조데이터테이블 데이터 셋
        ucPannel.UserControl11 uc11 = new ucPannel.UserControl11(); //딜리게이트
        ucPannel.UserControl12 uc12 = new ucPannel.UserControl12(); //쓰레드
        ucPannel.UserControl13 uc13 = new ucPannel.UserControl13(); //쓰레드


        private int _locationx = 0;
        private int _locationy = 0;


        private static Form1 instance;

        public int Locationx { get => _locationx; set => _locationx = value; }
        public int Locationy { get => _locationy; set => _locationy = value; }



        public Form1()
        {
            InitializeComponent();
        }

        public static Form1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Form1();
                }

                return instance;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            uc7.usercloseeven(); //7번 종료할때 파일저장
        }

        private void form_load(object sender, EventArgs e)
        {
            panel1.Controls.Add(uc1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            panel1.Controls.Add(uc1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uc2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uc3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uc4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uc5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uc6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uc7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uc8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uc9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uc10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uc11);
        }

        public void button12_Click(object sender, EventArgs e)
        {


            Console.WriteLine(Locationx);
            Console.WriteLine(Locationy);

            location();


            panel1.Controls.Clear();
            panel1.Controls.Add(uc12);

        }


        #region
        public void location()
        {
            Locationx = this.Location.X;
            Locationy = this.Location.Y;

            Form1.Instance.Locationx = Locationx;
            Form1.Instance.Locationy = Locationy;
            Console.WriteLine(Locationx);
        }

        #endregion

        private void button13_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uc13);
        }
    }

}