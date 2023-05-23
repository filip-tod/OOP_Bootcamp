using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vijezba3
{
     class Animals
    {
        public string Name;
        public string Breed;
        public int Age;

        Animals()
        {
        Name= "Rex";
        Breed = "German Shepard";
        Age = 3;
        }

        public void DogInfo()
        {
            Console.WriteLine("dog name is: " + Name);
            Console.WriteLine("dog breed is: " + Breed);
            Console.WriteLine("dog age is: " + Age);
        }
        static void Main(string[] args)
        {
            //istanciranje novog objekta
            Animals animals = new Animals();
            //pozivanje novog objekta (obj)
            animals.DogInfo();

            Console.WriteLine("name of dog is : " + animals.Name);
            Console.WriteLine("the breed of the dog is : " + animals.Breed);
            Console.WriteLine("Age of dog is : " + animals.Age);
        }
      
    }
   

}
