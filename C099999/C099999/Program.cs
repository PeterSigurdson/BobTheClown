using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C099999
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.name = "Fido";
            d1.age = 3;
            d1.SayHello();
        }
    }
    class Dog
    {
        Random rand = new Random();
        public string name;
        public int age;
        public int Strength;

        public Dog()
        {
            Strength = rand.Next(1, 100);
        }

        public void SayHello()
        {
            Console.WriteLine("My name is {0}  My strength is {1} ", name, Strength);
        }
    }
}
