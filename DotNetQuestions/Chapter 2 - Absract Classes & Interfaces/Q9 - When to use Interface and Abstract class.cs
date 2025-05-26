namespace Chapter_2___Absract_Classes___Interfaces
{
    #region When to use Interface
    public class Document : IPrintable // Document Class is unrelated with Invoice
    {
        public void Print()
        {
            Console.WriteLine("Printing Document...");
        }
    }

    public class Invoice : IPrintable // Invoice class is unrelated with Document
    {
        public void Print()
        {
            Console.WriteLine("Printing Invoice...");
        }
    }

    public interface IPrintable // Both Document and Invoice implements a common behaviour
    {
        void Print();
    }
    #endregion

    #region When to use Abstract Class
    public class PermanentEmployee : EmployeeDress//(Inherited Abstract Class)
    {
        public override void DressCode()
        {
            Console.WriteLine();
        }
    }

    public class ContractualEmployee : EmployeeDress//(Inherited Abstract Class)
    {
        public override void DressCode()
        {
            Console.WriteLine();
        }
    }

    public abstract class EmployeeDress // Abstract Class 
    {
        public abstract void DressCode(); //Abstract method 

        public void DressColour() // Concrete method which we know that it is same for all derived class
        {
            Console.WriteLine("Blue");
        }
    }

    #endregion
}
