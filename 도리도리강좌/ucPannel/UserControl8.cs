using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace 도리도리강좌.ucPannel
{
    public partial class UserControl8 : UserControl
    {
        Queue<int> _que = new Queue<int>(6); //선입선출 먼저들어온수가 첫번째원소
        Stack<int> _stack = new Stack<int>(6);   //후입선출 나중에 들어온수가 첫번째원소

        public UserControl8()
        {
            InitializeComponent();
        }


        //입력
        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int idata = rd.Next(1, 101);

            //que 데이터입력
            if (_que.Count < 6) //큐 값이 6개보다 작으면
            {
                _que.Enqueue(idata); //먼저들어온수가 첫번째원소
                qViewData();
            }

            //stack 데이터입력
            if (_stack.Count < 6) //큐 값이 6개보다 작으면
            {
                _stack.Push(idata); // //후입선출 나중에 들어온수가 첫번째원소
                sViewData();
            }

        }

        private void qViewData()
        {
            int[] arr = _que.ToArray();
            Array.Resize(ref arr, 6); //배열크기를 새로운크기로 지정한다.

            labelQ0.Text = arr[0].ToString();
            labelQ1.Text = arr[1].ToString();
            labelQ2.Text = arr[2].ToString();
            labelQ3.Text = arr[3].ToString();
            labelQ4.Text = arr[4].ToString();
            labelQ5.Text = arr[5].ToString();
        }

        private void sViewData()
        {
            int[] arr = _stack.ToArray();
            Array.Resize(ref arr, 6); //배열크기를 새로운크기로 지정한다.

            labelS0.Text = arr[0].ToString();
            labelS1.Text = arr[1].ToString();
            labelS2.Text = arr[2].ToString();
            labelS3.Text = arr[3].ToString();
            labelS4.Text = arr[4].ToString();
            labelS5.Text = arr[5].ToString();
        }

        //삭제 
        private void button3_Click(object sender, EventArgs e)
        {
            questackdelete();
        }

        public void questackdelete()//삭제 함수
        {
            //que 데이터입력
            if (_que.Count > 0) //큐 값이 0개보다 크면
            {
                _que.Dequeue(); //먼저들어온수가 먼저빠진다
                qViewData();
            }

            //stack 데이터입력
            if (_stack.Count > 0) //큐 값이 0개보다 크면
            {
                _stack.Pop(); //나중에 들어온수가 먼저빠진다
                sViewData();
            }

        }

        Timer timer = new Timer();
        bool btimer = false;



        private void button2_Click(object sender, EventArgs e)
        {
            if (btimer)
            {
                timer.Stop();
                btimer = false;

            }
            else
            {
                timer.Interval = 1000;
                timer.Tick += Timer_Tick;
                timer.Start();
                btimer = true;
            }

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            questackdelete();
        }
    }
}
