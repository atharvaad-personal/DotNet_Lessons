using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7___Important_Keywords
{
    internal class Q29___What_is_the_purpose_of__using__keyword_in_C_
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("file.txt"))
            {
                string line = reader.ReadLine();
            }

        }
    }
}
