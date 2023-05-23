using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task
{
    //baza apstraktne klase
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Extinct { get; set; }


        //konstruktor za class Animals
        public Animal(string Name, int Age, bool Extinct)
        {
            this.Name = Name;
            this.Age = Age;
            this.Extinct = Extinct;
        }

        //poziv za ispisivanje apstraktne metode
        public abstract void IspisInfo();

        public class Dog : Animal
        {
            public string Breed { get; set; }
            public Dog(string name, int age, bool extinct, string breed) : base(name, age, extinct)
            {
                Breed = breed;
            }

            public override void IspisInfo()
            {
                Console.WriteLine($"Pas - Ime: {Name}, Godine: {Age}, Da li je živ: {Extinct} ,Pasmina: {Breed}");
            }
        }

        //Metoda specifična za pse
        public void Barking()
        {
            Console.WriteLine("Wuuf, Wuuf!");
        }
    }

    public class Mammoth : Animal
    {
        public string Color { get; set; }

        public Mammoth(string name, int age, string color, bool extinct) : base(name, age, extinct)
        {
            Color = color;
        }
        // Implementacija apstraktne metode IspisiInformacije()
        public override void IspisInfo()
        {
            Console.WriteLine($"mammoth - Ime: {Name}, Godine: {Age}, Boja: {Color}, Izumrla: {Extinct}");
        }
        // Metoda specifična za mamute
        public void glasanjeSlona()
        {
            Console.WriteLine("Moooooo...:'D");
        }
    }

    //glavni program u kojemu pozivam sve principe
    class Program
    {
        static void Main(string[] args)
        {
            // Kreiramo objekte pas i mammoth
            Dog dog = new dog("Rex", 5, false ,"Njemački ovčar");
            Mammoth mammoth = new mammoth("Roki",20,"Mamut", "Brown", true);

            // Ispisujemo informacije o životinjama koristeći polimorfizam
            dog.IspisInfo();
            mammoth.IspisInfo();

            // Pozivamo metode specifične za pas i mačku
            dog.Barking();
            mammoth.glasanjeSlona();
        }
    }
}