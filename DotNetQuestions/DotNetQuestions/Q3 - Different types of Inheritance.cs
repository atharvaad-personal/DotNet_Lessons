namespace DotNetQuestions
{
    public class BaseClass
    {
        public void Animal()
        {
            Console.WriteLine("Animal");
        }
    }

    //public interface Interface
    //{
    //    public void Cat();
    //}

    public class DerivedClass : BaseClass/*, Interface*/
    { 
        public void Dog()
        {
            Console.WriteLine("Dog");
        }

        //public void Cat()
        //{
        //    Console.WriteLine("Cat");
        //}

        //static void Main(string[] args)
        //{
        //    DerivedClass derivedClass = new DerivedClass();
        //    derivedClass.Animal();
        //    derivedClass.Cat();
        //    derivedClass.Dog();
        //}
    }

    public class DerivedClass2 : BaseClass
    {
        public void Tiger()
        {
            Console.WriteLine("Tiger");
        }

        //static void Main(string[] args)
        //{
        //    DerivedClass2 derivedClass2 = new DerivedClass2();
        //    derivedClass2.Animal();
        //    derivedClass2.Tiger();

        //}
    }
}
