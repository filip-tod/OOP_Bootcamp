using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace vijezba3
{
    public class AnimalsFather
    {
        public string Name = "Rex";
        public void FatherMethode()
        {
            
            Console.WriteLine("ovo je metoda koja dohvaca podatke (father animal) :" + Name);
        }
    }
    public class AnimalsChild : AnimalsFather
    {
        public string NameChild { get; set; } = "Mrvica"; 
        public void ChildMethode()
        {
            Console.WriteLine("ovo je moetoda koja dohvaca podatke (child animal)" + NameChild);
        }
    }
    class Inharatance
    {
        static void Main(string[] args)
        {
            AnimalsFather fobj = new AnimalsFather();
            fobj.FatherMethode();

            //ovjde može child klasa prikazati sebe i father clasu
            AnimalsChild cobj = new AnimalsChild();
            cobj.FatherMethode();
            cobj.ChildMethode();
        }
    }
}
