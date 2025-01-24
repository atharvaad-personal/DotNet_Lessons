using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_DotNetC_
{
    public abstract class Animal
    {
        public abstract void MakeSound();

    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public abstract class Shape
    {

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new();
            dog.MakeSound();
        }
    }
}
