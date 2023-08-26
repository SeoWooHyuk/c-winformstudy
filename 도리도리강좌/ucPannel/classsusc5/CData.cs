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


        public string Stringitem {
            get {
                return stringitem;
            }
            set {
                if (string.IsNullOrEmpty(value)){
                    stringErrName = "물건이 선택되지않았습니다.";
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
                    stringErrName = "사장님만 가능한 범위입니다,";
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
                    stringErrName = "개별물품은 5개이상 살수없습니다.";
                }
                else if(value == 0)
                {
                    stringErrName = "물품의 개수가 0입니다.";
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

            if (String.IsNullOrEmpty(stringErrName)) //에러가 널이면 정상값을 받겠다
            {
                iitemPrice = (int)Enum.Parse(typeof(Enumitem), stringitem);
                dPrice = iitemPrice - Math.Round((double)iitemPrice + (double)iRate/100,2);
            }
            return dPrice + iCount;

        }
    }

    partial class CData
    {
   
    }
}
