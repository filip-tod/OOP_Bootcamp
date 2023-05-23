using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace vijezba3
{
     class Encapsulation
        //početak inkapsulacije
    {
        int x;

        public Encapsulation(int ix)
        {
            this.x = ix;
        }
        public void MySquare()
        {
            int rez = x + x;
            Console.WriteLine(rez);
            //kraj inkapsulacije
        }
    }
}
