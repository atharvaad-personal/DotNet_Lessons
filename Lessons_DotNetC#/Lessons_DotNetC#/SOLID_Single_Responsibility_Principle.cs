namespace Lessons_DotNetC_
{
    // Voilate SRP, because the clas has extra responsibility
    public class Employee_SOLID_Single_Responsibility_Principle
    {
        // Own Responsibility
        public int CalculateSalary()
        {
            return 1000;
        }

        // Extra Responsibility 1
        public void Save()
        {
            //save employee to the database
        }

        // Extra Resposibility 2
        public void SendMail(string mail)
        {
            Console.WriteLine(mail);
        }
    }


    // With SRP
    public class Employee_WithSPR
    {
        public int CalculateSalary()
        {
            return 1000;
        }

    }

    public class EmployeeRepository
    {
        public void Save()
        {
            //save employee to the database
        }
    }

    public class EmailSender
    {
        public void SendMail(string mail)
        {
            Console.WriteLine(mail);
        }
    }
}
