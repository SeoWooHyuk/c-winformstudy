using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 도리도리강좌.ucPannel.classsum
{
    class CCycle : CBase
    {
        public Rectangle _totalsquare; //자전거 몸통

        public Rectangle _rtcycle; //바퀴
        public Rectangle _rtsquarel;  //바퀴몸통

        public Rectangle _rtcycle2; //바퀴
        public Rectangle _rtsquarel2;  //바퀴몸통

        public CCycle(String name)
        {
            strName = name;

            _pen = new Pen(Color.Black, 3);

            _totalsquare = new Rectangle(80,120,240,20); //자전거 몸통
            _rtsquarel = new Rectangle(135, 140, 30, 60);
            _rtcycle = new Rectangle(120, 200, 60, 60); //바퀴가 그려짐

            _rtsquarel2 = new Rectangle(235, 140, 30, 60);
            _rtcycle2 = new Rectangle(220, 200, 60, 60); //바퀴가 그려짐
      
        }

        public Pen peninfo { get { return _pen; } }


        public void fmove(int imove) //외부에서움직이는거 표출
        {
            fpmove(imove);
        }

        protected void fpmove(int imove) //내부에서만 움직일것
        {
            Point point1 = _totalsquare.Location; //현재좌표점을 가져옴
            Point point2 = _rtsquarel.Location; //현재좌표점을 가져옴
            Point point3 = _rtsquarel2.Location; //현재좌표점을 가져옴
            Point point4 = _rtcycle.Location; //현재좌표점을 가져옴
            Point point5 = _rtcycle2.Location; //현재좌표점을 가져옴

            point1.X = point1.X + imove;
            _totalsquare.Location = point1;

            point2.X = point2.X + imove;
            _rtsquarel.Location = point2;

            point3.X = point3.X + imove;
            _rtsquarel2.Location = point3;

            point4.X = point4.X + imove;
            _rtcycle.Location = point4;

            point5.X = point5.X + imove;
            _rtcycle2.Location = point5;
        }
    }
}
