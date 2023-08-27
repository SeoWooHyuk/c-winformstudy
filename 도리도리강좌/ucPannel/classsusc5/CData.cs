using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 도리도리강좌.ucPannel.classsusc5
{

    partial class CData
    {
        private string stringitem  = string.Empty;
        private int iRate = 0;
        private int iCount = 0;
        private string stringErrName = string.Empty;

        private double totalprice = 0;

        public double GetTotalprice()
        {
            return totalprice;
        }

        public void SetTotalprice(double value)
        {


            totalprice = totalprice + value;
        }

        public string Stringitem {
            get {
                return stringitem;
            }
            set {
                if (string.IsNullOrEmpty(value)){

                   // stringErrName = "물건이 선택되지않았습니다.";
                    throw new Myexception("물건이 선택되지않았습니다.");
                }
                else {
                
                    stringitem = value;
                }
                
            }
        }

        public int IRate {
            get { 
               return iRate; 
            } 
            
            set {
                if (value > 20)
                {
                    throw new Myexception("사장님만 가능한 범위입니다,");
                    //stringErrName = "사장님만 가능한 범위입니다,";
                }
                else{
               
                    iRate = value;
                  
                }
               
            } 
        
        
        }

        public int ICount {
            get{
               return iCount;
            } 
            set {
                if (value > 5)
                {
                    throw new Myexception("개별물품은 5개이상 살수없습니다.");
                    //stringErrName = "개별물품은 5개이상 살수없습니다.";
                }
                else if(value == 0)
                {
                    throw new Myexception("물품의 개수가 0입니다.");
                    //stringErrName = "물품의 개수가 0입니다.";
                }
                else
                {
                
                    iCount = value;
                }
            }
        }
        public string StringErrName { 
            get => stringErrName; 
           // set => stringErrName = value; 
        }
     
    }

    partial class CData
    {
        public double fitemPirce()
        {
            double dPrice = 0;
            int iitemPrice =0;

            iitemPrice = (int)Enum.Parse(typeof(Enumitem), stringitem);  //정가
            double discountamount = Math.Round((double)iitemPrice * (double)iRate / 100, 2); //할인받은 금액
            dPrice = iitemPrice - discountamount; // 판매가격

            //if (String.IsNullOrEmpty(stringErrName)) //문자열이 null이거나 비어 있을때 실행
            //{
                
            //    iitemPrice = (int)Enum.Parse(typeof(Enumitem), stringitem);  //정가
            //    double discountamount = Math.Round((double)iitemPrice * (double)iRate / 100,2); //할인받은 금액
            //    dPrice = iitemPrice - discountamount; // 판매가격
            //}
            return dPrice * iCount;

        }
    }

    partial class CData
    {
        public String fresult(double dprice)
        {
            return string.Format("{0} * {1} : {2}원  (할인율 : {3}%)", Stringitem, ICount , dprice, IRate);
        
        }
    }
}
