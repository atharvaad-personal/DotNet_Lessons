namespace Chapter_6___METHODS___DELEGATES
{
    internal class Q23___What_is_the_purpose_of__params__keyword
    {
        public static int Add(params int[] numbers)
        {
            int total = 0;
            foreach (int i in numbers)
            {
                total += i;
            }
            return total;
        }

        //static void Main(string[] args)
        //{
        //    int sum = Add(8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19);
        //    Console.WriteLine(sum);
        //}
    }
}
