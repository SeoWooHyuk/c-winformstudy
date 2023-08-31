using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
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



        public UserControl12()
        {
            InitializeComponent();
        }


        private void btstart_Click(object sender, EventArgs e)
        {
            int locationX = Form1.Instance.Locationx + this.Size.Width + 15;
            int locationY = Form1.Instance.Locationy;

            int number = (int)numberup.Value;

            for (int i = 0; i < number; i++)
            {
                Player player = new Player(((enumPlay)i).ToString());
                player.Location = new Point(locationX, locationY + player.Height * i);
                player.eventdelMessage += Player_eventdelMessage;
                player.threadStart();
                player.Show();
            }


        }

        private int Player_eventdelMessage(object sender, string strResult)
        {
            if (this.InvokeRequired) //요청한 쓰레드가 현재 메인쓰레드의 컨트롤러를 엑세슬할수있는지
            {

                this.Invoke(new Action(() => //그림을 그릴때만 메인스레드에 위임한다
                {

                    Player opplay = sender as Player;
                    listBox1.Items.Add(string.Format("player {0} , text : {1}", opplay.StrplayerName, strResult));

                }));

            }


            return 0;
        }
    }

    class Player : Form
    {
        Label playername;
        Label playerpersent;
        ProgressBar progressBar;
        Button playerbutton;

        Thread thread = null;

        public delegate int delMessage(object sender, string strResult);
        public event delMessage eventdelMessage;

        string _strplayerName = string.Empty;

        public string StrplayerName { get => _strplayerName; set => _strplayerName = value; }

        public Player() { }

        public Player(string strplayerName)
        {

            playername = new Label();
            playerpersent = new Label();
            progressBar = new ProgressBar();
            playerbutton = new Button();


            this.FormBorderStyle = FormBorderStyle.None;
            this.Width = 550;
            this.Height = 100;
            this.BackColor = Color.Aqua;
            this.StartPosition = FormStartPosition.Manual;
            playername.AutoSize = true;
            playername.Top = 8;
            playername.Left = 5;
            playername.Text = StrplayerName = strplayerName;
            playername.TextAlign = ContentAlignment.MiddleCenter;
            //playername.BorderStyle = BorderStyle.FixedSingle;
            playername.Parent = this;

            playerbutton.AutoSize = true;
            playerbutton.Top = 5;
            playerbutton.Left = playername.Right + 10;
            playerbutton.Text = "포기";
            playerbutton.Click += Playerbutton_Click;
            playerbutton.Parent = this;

            playerpersent.AutoSize = true;
            playerpersent.Top = 8;
            playerpersent.Left = this.Right - playerpersent.Width - 80;
            playerpersent.Text = "진행 상황 표시 : 0%";
            playerpersent.TextAlign = ContentAlignment.MiddleCenter;
            playerpersent.Parent = this;


            progressBar.Width = this.Width - 30;
            progressBar.Height = 50;
            progressBar.Left = 15;
            progressBar.Top = playerbutton.Bottom + 10;
            progressBar.Parent = this;

        }


        private CancellationTokenSource cancellationTokenSource;
        bool threadcheck = false;

        public void Run(CancellationToken cancellationToken)
        {
            // CheckForIllegalCrossThreadCalls = false;  //크로스 쓰레드 예외 해제 왠만하면 쓰지말자 강제로 예외무시하는행동이라서

            try
            {
                int ivar = 0;
                Random rd = new Random();

                while (progressBar.Value < 100)
                {
                    cancellationToken.ThrowIfCancellationRequested(); // 요청 시 중단

                    if (this.InvokeRequired) //요청한 쓰레드가 현재 메인쓰레드의 컨트롤러를 엑세슬할수있는지
                    {

                        this.Invoke(new Action(() => //그림을 그릴때만 메인스레드에 위임한다
                        {
                            ivar = rd.Next(1, 11);

                            if (progressBar.Value + ivar > 100)
                            {
                                progressBar.Value = 100;
                            }
                            else
                            {
                                progressBar.Value = progressBar.Value + ivar;
                            }

                            playerpersent.Text = string.Format("진행 상황 표시 : {0}%", progressBar.Value);
                            this.Refresh();

                        }));
                        Thread.Sleep(300);
                    }
                    if (threadcheck)
                    {
                        eventdelMessage(this, string.Format("중도포기"));
                    }
                }
               
                  
                   eventdelMessage(this, "완주!! complete");
                

            }
            catch (OperationCanceledException ex) //CancellationToken에서 ThrowIfCancellationRequested() 호출 시 발생하는 예외 처리
            {
                ex.ToString();
            }
        }
        

        private void Playerbutton_Click(object? sender, EventArgs e)
        {
            // MessageBox.Show("확인");
            threadAbort();
            threadcheck = true;
        }


        public void threadStart() { //쓰레드 시작

            cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            thread = new Thread(() => Run(cancellationToken));
            thread.IsBackground = true; //자바에서 데몬설정과 같은 메인쓰레드를 끝내면 다같이중지
            thread.Start();

        }

        public void threadAbort() //실행중인 쓰레드 강제종료  threadAbort는  net 5.0이상부터 지원안함
        {
            if (cancellationTokenSource != null && !cancellationTokenSource.IsCancellationRequested)
            {
                cancellationTokenSource.Cancel(); // 쓰레드 중단 요청 
            }
        }

        public void threadJoin()
        {
            if (thread.IsAlive) //쓰레드가동작중일때 쓰레드를 종료하겠다
            {
                bool threadEnd = thread.Join(3000);
            }
        
        }

        public void ThreadInterrupt()
        {
            if (thread.IsAlive)
            {
                thread.Interrupt();
            }
        }




    }
}


