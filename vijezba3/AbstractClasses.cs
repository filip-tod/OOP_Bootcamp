using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace vijezba3
{
   public abstract class User
    {
        public abstract void displayData();

        public class NewUser : User
        {
            //metoda implementacije abstraktne klase
            public override void displayData()
            {
                Console.WriteLine("ovo je sada implementacija nove klasu na abstraktnu klasu");
            }
        }
        class abstractClass
        {
            static void Main(string[] args)
            {
                // class instance
                new NewUser().displayData();
            }
        }
    }
}
