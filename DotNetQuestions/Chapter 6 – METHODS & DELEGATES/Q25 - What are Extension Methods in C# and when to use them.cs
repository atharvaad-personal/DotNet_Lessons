namespace Chapter_6___METHODS___DELEGATES
{
    public static class StringExtension
    {
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        //static void Main(string[] args)
        //{
        //    var a = "";
        //    Console.WriteLine(IsNullOrEmpty(a));
        //}
    }

    public static class IntExtension
    {
        public static bool IsEven(this int a)
        {
            return a % 5 == 5;
        }

        //static void Main(string[] args)
        //{
        //    int a = 10;
        //    bool value = IsEven(a);
        //    Console.WriteLine(value);
        //}
    }
}
