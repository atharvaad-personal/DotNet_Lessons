namespace DotNetQuestions
{
    public class Employees //👈 Parent Class
    {
        public int Exprience { get; set; }

        public void CalculateSalary()
        {
            int salary = Exprience * 30000;
            Console.WriteLine(salary);
        }
    }

    public class PermanentEmpoyee : Employees  //👈 PermanentEmpoyee Class is Derived Class
    {
        // Code

        //static void Main(string[] args)
        //{
        //    PermanentEmpoyee pEmployee = new PermanentEmpoyee();
        //    pEmployee.Exprience = 3;
        //    pEmployee.CalculateSalary();
        //    Console.ReadLine();

        //}
    }
}
