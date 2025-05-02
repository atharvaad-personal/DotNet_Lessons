namespace DotNetQuestions
{
    public class Employee
    {
        public Employee() // 👈 Constructor
        {
                //code 
        }

        //private int exprience; // 👈 Field

        //public int Exprience 👈 Propperty
        //{
        //    get { return exprience; }
        //    set { exprience = value; }
        //}

        public int Exprience { get; set; } // 👈 Propperty

        public void CalculateSalary()  // 👈 Method
        {
            int salary = Exprience * 30000;
            Console.WriteLine(salary);
        }

        //static void Main(string[] args)
        //{
        //    Employee oldEmployee = new Employee();
        //    oldEmployee.Exprience = 3;
        //    oldEmployee.CalculateSalary();
        //    Console.ReadLine();
        //}
    }
}
