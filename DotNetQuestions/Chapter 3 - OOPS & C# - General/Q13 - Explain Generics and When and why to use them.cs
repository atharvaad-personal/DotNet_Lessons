namespace Chapter_2___Absract_Classes___Interfaces
{
    public /*static*/ class Comparison<T>
    {
        public static bool AreEqual(T a, T b)
        {
            return a.Equals(b);
        }

        //public static bool AreEqual(object a, object b)
        //{
        //    return a.Equals(b);
        //}

        //static void Main(string[] args)
        //{
        //    bool equal = Comparison<int>.AreEqual(1, 2);
        //    bool stringEqual = Comparison<string>.AreEqual("Interview", "Interview");
        //    Console.WriteLine($"Integer Comparision {equal}" +
        //        $"\nString comparison - {stringEqual}");
        //}
    }
}
