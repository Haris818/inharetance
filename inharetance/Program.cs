using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inharetance
{


    class Human
    {
        public string name;
        public int age;

        public void Eat()
        {
            Console.WriteLine("my animal is eating");
        }
    }

    class HARIS : Human
    {
        public void Bar()
        {
            Console.WriteLine($"MY NAME IS {name} MY AGE IS {age} ");
        }
    }


    class TALHA : Human
    {
        public void Meow()
        {
            Console.WriteLine($"MY NAME IS  {name} MY AGE IS {age}");
        }
    }

    class HADI : Human
    {
        public void Me()
        {
            Console.WriteLine($"MY NAME IS  {name} MY AGE IS {age}");
        }
    }

    class MAHEEN : Human
    {
        public void you()
        {
            Console.WriteLine($"MY NAME IS  {name} MY AGE IS {age}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
           HARIS  haris= new HARIS();
            TALHA talha= new TALHA();
            HADI hadi = new HADI();
            MAHEEN maheen = new MAHEEN();

            talha.age = 5;
            talha.name = "TALHA";
            haris.age = 18;
            haris.name = "HARIS";
            hadi.name = "HADI";
            hadi.age = 6;
            maheen.name = "MAHEEEN";
            maheen.age = 20;

            hadi.Me();
            haris.Bar();
            talha.Meow();
            maheen.you();
            Console.ReadKey();
        }
    }
}



