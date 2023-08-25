namespace 도리도리강좌
{
    public partial class Form1 : Form
    {
        ucPannel.UserControl1 uc1 = new ucPannel.UserControl1(); //연산자
        ucPannel.UserControl2 uc2 = new ucPannel.UserControl2(); //계산기


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

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}