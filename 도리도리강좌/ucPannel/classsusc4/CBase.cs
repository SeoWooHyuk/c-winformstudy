using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 도리도리강좌.ucPannel.classsum
{
    class CBase
    {
        public string strName;
        protected Pen _pen;

        public CBase()
        {
            _pen = new Pen(Color.Red);
        }

    }
}
