namespace Chapter_6___METHODS___DELEGATES
{
    internal class Delegate
    {
        delegate void Calculator(int x, int y);
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Remove(int a, int b) 
        {
            Console.WriteLine(a - b);
        }

        //static void Main(string[] args)
        //{
        //    Calculator calculator = new Calculator(Add);// Passed method as parameter

        //    calculator += Remove;
        //    calculator(20, 30); // calling method using delegate
        //    Console.WriteLine(calculator);
        //}
    }
}
