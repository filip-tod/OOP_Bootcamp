using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace vijezba3
{
    internal class @interface
    {
        public interface ITemplatePerson
        {
            void Ime();
            void Prezime();
            
            //nisam stavio treću metodu jer je mogu naknadno dodata 
            //kada bi je trenutno deklarirao onda bi se i obvezao za njega

        }
         class Person : ITemplatePerson
        {
            public void Ime()
            {
                Console.WriteLine("Ime osobe je Matej");

            }
            public void Prezime()
            {
                Console.WriteLine("Prezime osobe je Matić");
            }
            public void Dob()
            {
                Console.WriteLine("dob osobe je hardkodana i 30 je");
            }
        }
        class interfaceDemo
        {
            static void Main(string[] args)
            {
                Person obj = new Person();
                obj.Ime();
                obj.Prezime();
                obj.Dob();
            }
        }
    }
}
