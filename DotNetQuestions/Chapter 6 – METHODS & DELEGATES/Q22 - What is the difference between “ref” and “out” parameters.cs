namespace Chapter_6___METHODS___DELEGATES
{
    internal class WithoutRefandOut // Parameter by Value
    {
        public int Add(out int m, ref int n)
        {
            m = 10;
            return m + n;
        }

        //static void Main(string[] args)
        //{
        //    //int a = 10;
        //    int a;
        //    int b = 20;

        //    WithoutRefandOut withoutRefandOut = new WithoutRefandOut();
        //    int x = withoutRefandOut.Add(out a, ref b);
        //    Console.WriteLine(x);
        //}
    }
}
