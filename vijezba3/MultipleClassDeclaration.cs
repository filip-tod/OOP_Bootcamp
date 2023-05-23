using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vijezba3
{
     class MultipleClassDeclaration
    {
     public void FirstIstance()
        {
            Console.WriteLine("prva istanca deklaracije objekta");
        }
        static void Main(string[] args)
        {
            //prva istanca 
            MultipleClassDeclaration firstOne =  new MultipleClassDeclaration();
            firstOne.FirstIstance();

            //druga istanca 
            MultipleClassDeclaration2 secondOne = new MultipleClassDeclaration2();
            secondOne.SecondIstance();
        }
    }
    class MultipleClassDeclaration2
    {
        int x = 2;
        int y = 3;
        int z;

        public void SecondIstance()
        {
            z = x + y;
            Console.WriteLine("treći indeks (z) je : " + z);
        }
    }
}
