using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vijezba3
{
    public abstract class NbaPlayer
    {
        public virtual void PlayerName()
        {
        }
    }
    public class PheonixPlayer : NbaPlayer
    {
        public override void PlayerName()
        {
            Console.WriteLine("My name is Devin Booker");
        }
        public class DenverPlayer : NbaPlayer
        {
            public override void PlayerName()
            {
                Console.WriteLine("My name is Nikola Jokić MVP");
            }
        }
        public class TorontoPlayer : NbaPlayer
        {
            public override void PlayerName()
            {
                Console.WriteLine("My name is Pascal Siakam");
            }
        }
        class Polymorphism
        {
            static void Main(string[] args)
            {
                PheonixPlayer obj1 = new PheonixPlayer();
                DenverPlayer obj2 = new DenverPlayer();
                TorontoPlayer obj3 = new TorontoPlayer();

                //ReadKey na klik uzima sljedecu funkciju
                Console.ReadKey();
            }
        }
    }
}
  
