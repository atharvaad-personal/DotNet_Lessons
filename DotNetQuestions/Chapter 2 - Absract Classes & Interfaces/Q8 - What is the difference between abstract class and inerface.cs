namespace Chapter_2___Absract_Classes___Interfaces
{
    public abstract class Employee
    {
        public abstract void Project();

        public void Role()
        {
            Console.WriteLine("Developer");
        }
    }

    public interface IEmployee
    {
        void Role();
    }
}
