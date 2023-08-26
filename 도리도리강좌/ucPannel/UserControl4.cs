using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 도리도리강좌.ucPannel.classsum;

namespace 도리도리강좌.ucPannel
{
    public partial class UserControl4 : UserControl
    {
        ConeCycle coneSycle;
        CCycle cCycle;

        public UserControl4()
        {
            InitializeComponent();
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            coneSycle = new ConeCycle("외발자전거");
            cCycle = new CCycle("자전거");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelclear();
            coneSycleDraw();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            panelclear();
            SycleDraw();




        }

        public void coneSycleDraw() {
  
            label1.Text = coneSycle.strName;
            Graphics g = panel1.CreateGraphics(); //판넬에다가 그래픽을 그리겠다
            Pen p = coneSycle.penInfo;
            g.DrawRectangle(p, coneSycle._rtsquarel);
            g.DrawEllipse(p, coneSycle._rtcycle);
        }

        public void SycleDraw()
        {
         
            label1.Text = cCycle.strName;
            Graphics g = panel1.CreateGraphics();
            Pen p = cCycle.peninfo;
            g.DrawRectangle(p, cCycle._totalsquare);
            g.DrawRectangle(p, cCycle._rtsquarel);
            g.DrawEllipse(p, cCycle._rtcycle);
            g.DrawRectangle(p, cCycle._rtsquarel2);
            g.DrawEllipse(p, cCycle._rtcycle2);
        }



        private void button5_Click(object sender, EventArgs e) //오른쪽으로가라
        {
            panelclear();

            switch (label1.Text)
            {
                case "외발자전거":
                    coneSycle.fmove(20);
                    coneSycleDraw();
                   break;
                case "자전거":
                    cCycle.fmove(20);
                    SycleDraw();
                    break;


                default:
                    break;
            }
        
        }

        private void button4_Click(object sender, EventArgs e) //왼쪽으로가라
        {
            panelclear();
            switch (label1.Text)
            {
                case "외발자전거":
                    coneSycle.fmove(-20);
                    coneSycleDraw();
                    break;
                case "자전거":
                    cCycle.fmove(-20);
                    SycleDraw();
                    break;


                default:
                    break;
            }

        }


        //판넬클리어 함수
        public void panelclear()
        {
            panel1.Invalidate(); //판넬 클리어
            Refresh(); //새로고침 같은개념

        }
    }
}
