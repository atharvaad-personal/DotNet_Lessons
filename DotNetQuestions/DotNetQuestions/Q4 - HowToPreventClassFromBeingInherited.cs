using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetQuestions
{
    public sealed class HowToPreventClassFromBeingInherited
    {
        public int Exprience { get; set; }

        public void CalculateSalary()
        {
            int salary = Exprience * 30000;
            Console.WriteLine(salary);
        }
    }

    public class Associates /*: HowToPreventClassFromBeingInherited*/ //Commented as it was throwing error.
    {

    } 
}
