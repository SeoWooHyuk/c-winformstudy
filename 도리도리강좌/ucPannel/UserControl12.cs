using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace 도리도리강좌.ucPannel
{



    public partial class UserControl12 : UserControl
    {
        private enum enumPlay
        {
            아이린,
            슬기,
            웬디,
            조이,
            예리,
        }



        Form player1;
        Label playername;
        Label playerpersent;
        ProgressBar progressBar;
        Button playerbutton;

        //Thread _thread = null;


        //public void threadstart()
        //{
        //   // _thread = new Thread(new ThreadStart(Run)); //쓰레드 스타트라는 델리게이트 함수를 타입 객체를 생성한후 함수를 델리게이트로 넘김

        //    _thread = new Thread(Run); //컴파일러에서 델리게이트 객체를 추론하여 생성후 함수넘김

        //    // _thread = new Thread(delegate () { Run(); }); //악명메서드를 사용하여 함수를 넘김
        //    _thread.Start();

        //}

        //public void Run()
        //{
        //    test();
        //}


        public UserControl12()
        {
            InitializeComponent();
        }


        private void btstart_Click(object sender, EventArgs e)
        {


            int number = (int)numberup.Value;

            for (int i = 0; i < number; i++)
            {
                player1chekc(i, ((enumPlay)i).ToString());
               
            }

            
        }

        public void player1chekc(int i, string player)
        {

            playername = new Label();
            playerpersent = new Label();
            progressBar = new ProgressBar();
            playerbutton = new Button();

            //if (player1 != null) //버튼을 누를때마다 폼을 지웠다 만든다
            //{
            //    player1.Dispose(); //폼을 없앤다
            //    player1 = null;
            //}
            player1 = new Form();
            player1.FormBorderStyle = FormBorderStyle.None;
            player1.Width = 550;
            player1.Height = 100;
            player1.BackColor = Color.Aqua;
            player1.StartPosition = FormStartPosition.Manual;
            playername.AutoSize = true;
            playername.Top = 8;
            playername.Left = 5;
            playername.Text = player;
            playername.TextAlign = ContentAlignment.MiddleCenter;
            //playername.BorderStyle = BorderStyle.FixedSingle;
            playername.Parent = player1;

            playerbutton.AutoSize = true;
            playerbutton.Top = 5;
            playerbutton.Left = playername.Right + 10;
            playerbutton.Text = "포기";
            playerbutton.Parent = player1;

            playerpersent.AutoSize = true;
            playerpersent.Top = 8;
            playerpersent.Left = player1.Right - playerpersent.Width - 80;
            playerpersent.Text = "진행 상황 표시 : 0%";
            playerpersent.TextAlign = ContentAlignment.MiddleCenter;
            playerpersent.Parent = player1;


            progressBar.Width = player1.Width - 30;
            progressBar.Height = 50;
            progressBar.Left = 15;
            progressBar.Top = playerbutton.Bottom + 10;
            progressBar.Parent = player1;

            int locationX = Form1.Instance.Locationx + this.Size.Width + 15;
            int locationY = Form1.Instance.Locationy;

            Console.WriteLine(locationX + "X체크");
            Console.WriteLine(locationY + "Y체크");
            player1.Location = new Point(locationX, locationY + player1.Height * i);
            player1.Show();

            Thread thread = new Thread(() =>
            {
                Run();
            });
            thread.Start();

            //test(); 단일스레드 사용 하나하고 넘기고 하나하고 넘기고
        }

        public void Run()
        {
            CheckForIllegalCrossThreadCalls = false; 
            int ivar = 0;
            Random rd = new Random();

            while (progressBar.Value < 100)
            {
                ivar = rd.Next(1,11);


                if (progressBar.Value + ivar > 100)
                {
                    progressBar.Value = 100;
                }
                else
                {
                    progressBar.Value = progressBar.Value + ivar;
                }

                playerpersent.Text = string.Format("진행 상황 표시 : {0}%", progressBar.Value);
                player1.Refresh();
                Thread.Sleep(300);

            }
        }

      
    }
}
