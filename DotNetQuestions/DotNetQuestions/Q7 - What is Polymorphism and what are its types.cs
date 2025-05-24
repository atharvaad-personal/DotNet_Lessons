namespace DotNetQuestions
{
    public class Polymorphism
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public string Add(string str1, string str2)
        {
            return str1 + str2;
        }

        //static void Main(string[] args)
        //{
        //   Polymorphism polymorphism = new Polymorphism();
        //   var p = polymorphism.Add(2, 8);
        //   var t = polymorphism.Add("Interview", "Questions");

        //    Console.WriteLine(p + "-"+ t);
        //}
    }

    public class MethodOverloading
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }

        public double Add(double a, int c, double b)
        {
            return a + b + c;
        }

        //static void Main(string[] args)
        //{
        //    MethodOverloading methodOverloading = new MethodOverloading();
        //    methodOverloading.Add(1, 2);
        //    var x = methodOverloading.Add(1, 1, 4);
        //    var y = methodOverloading.Add(2, 2.3, 3.5);
        //    var z = methodOverloading.Add(3.8, 8, 4.6);

        //    Console.WriteLine($"Number of Parameters are different - {x}\n"
        //                    + $"Types of Parameters are different - {y}\n"
        //                    + $"Orders of Parameters are different - {z}\n");
        //}

    }

    public class MethodOverriding
    {
        public class BaseClass
        {
            public virtual void Greetings()
            {
                Console.WriteLine("Hello from Base Class");
            }
        }

        public class DerivedClass : BaseClass
        {
            public override void Greetings()
            {
                Console.WriteLine("Hello from Derived Class");
            }
        }

        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Greetings();
        }
    }

    public class MethodHiding
    {
        public class Animal
        {
            // Non-virtual method (cannot be overridden)
            public void Eat()
            {
                Console.WriteLine("Animal is eating");
            }
        }

        public class Dog : Animal
        {
            // Method hiding (explicitly using 'new')
            public new void Eat()
            {
                Console.WriteLine("Dog is eating");
            }
        }

        static void Main(String[] args)
        {
            Animal myAnimal = new Animal();
            Animal myDogAsAnimal = new Dog(); // Treat Dog as Animal
            Dog myDog = new Dog();

            myAnimal.Eat();          // Output: "Animal is eating"
            myDogAsAnimal.Eat();     // Output: "Animal is eating" (compile-time resolution)
            myDog.Eat();             // Output: "Dog is eating"
        }
    }
}
