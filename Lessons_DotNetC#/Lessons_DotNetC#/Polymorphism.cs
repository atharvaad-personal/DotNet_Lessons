using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_DotNetC_
{
    public class Polymorphism
    {

        //Method Overloading (Compile-Time Polymorphism)

        public int Add(int a, int b)
        {
            return a + b;
        }

        //Method to add three integers (Overloaded)
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        //Method to add two doubles (Overloaded)
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    //Method Overriding (Run-Time Polymorphism)
    public class Animals
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    public class Dogs : Animals
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog Barks");
        }
    }

    public class Cat : Animals
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }
}

//Polymorphism occurs when a derived classnprovides a specific implementation of a method that is already defined in its base class.

//What is the difference betwwen method overrloading and method overrding?
//-> 1) Overloading - Same method name, different parameters, resolved at compile time.
//   2) Overriding - Same method signature resolved at run-time, requires virtual and override keywords.

//What is the difference between abstract and virtual?
//-> Abstract - Must be overriden in a derived class (no implementation in the base class)
//   Virtual - Can be overriden in a derived class (has a default implementation in the base class)
