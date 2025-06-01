using System.Collections;

namespace Chapter_2___Absract_Classes___Interfaces
{
    public class Q11___What_is_boxing_and_unboxing_and_where_to_use_them
    {
        public void BoxingAndUnboxing()
        {
            int a = 5;           // Value type (stack)
            object o = a;        // Boxing (heap)
            int b = (int)o;      // Unboxing (stack)

            ArrayList list = new ArrayList();
            list.Add(10);           // Boxing
            int value = (int)list[0]; // Unboxing

            List<int> numbers = new List<int>();
            numbers.Add(10);       // No boxing
        }

        //static void Main(string[] args)
        //{
        //    int num = 10; // int is Value Type
        //    object obj = num; // obj is reference type  // Boxing
        //    int o = (int)obj; // Unboxing
        //}
    }
}
