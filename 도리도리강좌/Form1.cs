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


        public Form1()
        {
            InitializeComponent();
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

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}