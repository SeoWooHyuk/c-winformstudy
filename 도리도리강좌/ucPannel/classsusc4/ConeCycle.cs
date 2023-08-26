using Accessibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 도리도리강좌.ucPannel.classsum
{
    class ConeCycle : CBase
    {
        public Rectangle _rtcycle; //바퀴
        public Rectangle _rtsquarel;  //몸통

        public ConeCycle(string sName)
        {
            strName = sName;
            _pen = new Pen(Color.Black,3);

      
            _rtsquarel = new Rectangle(150,30,60,120); //몸통
            _rtcycle = new Rectangle(120, 150, 120, 120); //바퀴가 그려짐


        }

        public Pen penInfo { get { return _pen; } }

        public void fmove(int imove) //외부에서움직이는거 표출
        {
            fpmove(imove);
        }

        protected void fpmove(int imove) //내부에서만 움직일것
        {
            Point point1 = _rtsquarel.Location; //현재좌표점을 가져옴
            Point point2 = _rtcycle.Location; //현재좌표점을 가져옴
            
            point1.X = point1.X + imove;
            _rtsquarel.Location = point1;

            point2.X = point2.X + imove;
            _rtcycle.Location = point2;
        }
    }
}
