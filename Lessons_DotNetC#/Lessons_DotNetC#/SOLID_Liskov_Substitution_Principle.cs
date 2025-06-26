namespace Lessons_DotNetC_
{
    // Base / Parent / Super
   public class EmployeeLSP
    {
        public virtual int CalculateSalary()
        {
            return 100000;
        }

        public virtual int CalculateBonus()
        {
            return 10000;
        }
    }

    // Derived / Child / Subclass
    public class PermanantEmployeeLSP : EmployeeLSP
    {
        public override int CalculateSalary()
        {
            return 2000000;
        }
    }

    public class ContractualEmployeeLSP : EmployeeLSP
    {
        public override int CalculateSalary()
        {
            return 70000;
        }

        public override int CalculateBonus()
        {
            throw new NotImplementedException("Bonus does not applied on Contractual Employees");
        }

        static void Main(string[] args)
        {
            #region object of parent class
            EmployeeLSP employeeLSP = new EmployeeLSP();
            #endregion

            #region object of child classes 
            PermanantEmployeeLSP permanantEmployeeLSP = new PermanantEmployeeLSP();
            ContractualEmployeeLSP contractualEmployeeLSP = new ContractualEmployeeLSP();
            #endregion

            Console.WriteLine(employeeLSP.CalculateSalary()); // Output = 100000
            Console.WriteLine(employeeLSP.CalculateBonus()); // Output = 10000

            Console.WriteLine(permanantEmployeeLSP.CalculateSalary()); // Output = 2000000
            Console.WriteLine(permanantEmployeeLSP.CalculateBonus());// Output = 10000

            Console.WriteLine(contractualEmployeeLSP.CalculateSalary()); // Output = 2000000
            Console.WriteLine(contractualEmployeeLSP.CalculateBonus());// Error
        }
    }
}
