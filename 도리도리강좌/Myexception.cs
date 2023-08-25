using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 도리도리강좌
{
    internal class Myexception : Exception
    {

        public Myexception(string message ) :base(message) { }
      
    }
}
