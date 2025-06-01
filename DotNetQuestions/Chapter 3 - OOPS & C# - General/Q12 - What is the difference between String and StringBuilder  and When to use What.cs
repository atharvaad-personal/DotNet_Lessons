using System.Text;

namespace Chapter_2___Absract_Classes___Interfaces
{
    internal class Q12___What_is_the_difference_between_String_and_StringBuilder__and_When_to_use_What
    {
        public void StringAndStringBuilder()
        {
            String str1 = "Interview";
            str1 += "Prepration";
            str1 = str1 + "Prepration";

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                sb.Append(i); // In StringBuilder we called append for addition purpose
            }
            string result = sb.ToString();

        }
    }
}
