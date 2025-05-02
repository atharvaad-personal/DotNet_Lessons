namespace DotNetQuestions
{
    public class BaseClass
    {
        public void Animal()
        {
            Console.WriteLine("Animal");
        }
    }

    public interface Interface
    {
        public void Cat();
    }

    public class DerivedClass : BaseClass, Interface
    { 
        public void Dog()
        {
            Console.WriteLine("Dog");
        }

        public void Cat()
        {
            Console.WriteLine("Cat");
        }

        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Animal();
            derivedClass.Cat();
            derivedClass.Dog();
        }
    }
}
