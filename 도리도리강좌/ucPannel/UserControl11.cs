using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace 도리도리강좌.ucPannel
{
    public partial class UserControl11 : UserControl
    {

        public delegate int delFuncDow_Edge(int i);
        public delegate int delFuncTopping(string strOrder, int Ea);

        public delegate T delFunc<T>(T i);  // 함수 명 뒤에 <일반화 변수명 - 형식 매개 변수> 을 사용 할 경우 일반화 함수를 지정 할수 있음 (인자 값 Type에 신경 쓰지 않는 형태)
        public delegate A delTest<A>(A i);  // 문자 종류는 상관 없음 일반화 함수를 Delegate에도 적용할 수 있다는 점 (확장개념 일반화 delegate를 delegate의 특징이라고 보기는 어렵지 않을지)

        public delegate object delFuncO(object i); // var, object

        int _iTotalPrice = 0;

        ArrayList list = new ArrayList();

        public UserControl11()
        {
            InitializeComponent();
            //declick2();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
        }

        public int fCallBackDelegate(int i, delFuncDow_Edge dFunction)
        {
            return dFunction(i);
        }

        public void declick1()
        {
            int i = 2;
            delFuncDow_Edge delDow = new delFuncDow_Edge(fDow);  // public delegate int delFuncDow_Edge(int i);
            int a = fCallBackDelegate(i, delDow);
            Console.WriteLine(a);
        }

        private int fDow(int iOrder)
        {
            int price = 0;

            if (iOrder == 1)
            {
                price = 10000;
            }
            else if (iOrder == 2)
            {
                price = 20000;
            }

            return _iTotalPrice = _iTotalPrice + price;
        }

        //------------------------------------------------


        public void declick2()
        {
            delFuncTopping delTopping = null; //public delegate int delFuncTopping(string strOrder, int Ea);

            delTopping += fTopping1;  //순서대로 읽어서 출력한다.
            delTopping += fTopping2;  //순서대로 읽어서 출력한다

            delTopping("토핑", 1);

            flboxOrderRed("----------------------------------");
            flboxOrderRed(string.Format("전체 주문 가격은 {0}원 입니다.", _iTotalPrice));
        }




        private int fTopping1(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 500;
            strOrder = string.Format("소세지 {0} {1} 개를 선택 하였습니다. : ({2}원 (1ea 500원)", Order, iEa, iPrice);
            flboxOrderRed(strOrder);
            return _iTotalPrice = _iTotalPrice + iPrice;
        }

        private int fTopping2(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 1500;
            strOrder = string.Format("치즈 {0} {1} 개를 선택 하였습니다. : ({2}원 (1ea 1500원)", Order, iEa, iPrice);
            flboxOrderRed(strOrder);
            return _iTotalPrice = _iTotalPrice + iPrice;
        }


        private void flboxOrderRed(string strOrder)
        {
            list.Add(strOrder);
        }








    }
}
