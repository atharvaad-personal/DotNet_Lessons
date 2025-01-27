using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_DotNetC_
{
    public abstract class Animal
    {
        //Implementing abstract method which don't have implemenation
        public abstract void MakeSound();

    }

    public class Dog : Animal
    {
        //Implementing the method with override keyword
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public abstract class Shape
    {
        //abstract method
        public abstract void Draw();
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }
}

//abstract class - Hides the implementation and can't be instantiated
//abstract class can have both abstract method and non abstract method with implementation but in interface it is not possible we cannot define method in interface

//TypeCasting
//foreach( var InteratuinVariableName in List<Class>)
// var variableName = (className)IterationVariableName
                    //OR
//var variableName = IterationVariable as className
