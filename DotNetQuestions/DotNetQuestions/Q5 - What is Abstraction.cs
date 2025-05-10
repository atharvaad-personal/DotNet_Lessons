namespace DotNetQuestions
{
    public class Abstraction
    {
        #region Normal Explanation
        //static void Main(string[] args)
        //{
        //    string name = "InterviewQuestions";
        //    var names = name.Substring(5,4);
        //    Console.WriteLine(names);
        //}
        #endregion

        #region Implementation through Abstract Class
        //static void Main(string[] args)
        //{
        //    //This line creates a Employment object but stores it in a variable of type Abstraction. 
        //    //This is possible because Employment inherits from Abstraction 
        //    //(via public class Employment : Abstraction).
        //    Abstraction abstraction = new Employment();
        //    abstraction.Exprience = 9;
        //    abstraction.CalculateSalary();
        //    abstraction.CalculateBonus();
        //}

        //public int Exprience { get; set; }

        //public void CalculateSalary()
        //{
        //    int salary = Exprience * 30000;
        //    Console.WriteLine(salary);
        //}

        //public abstract void CalculateBonus();

        //public class Employment : Abstraction
        //{
        //    public override void CalculateBonus()
        //    {
        //        Console.WriteLine("Bonus is updated");
        //    }
        //}
        #endregion

        #region Implementation through Interfaces

        // Interface
        public interface ICircle
        {
            double CalculateArea();  // No implementation
        }

        // Concrete class
        public class Circle : ICircle
        {
            public double Radius { get; set; }

            public double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }
        }

        // Usage
        //static void Main(string[] args)
        //{
        //    Circle circle = new Circle() /*{ Radius = 5 }*/;
        //    circle.Radius = 5;
        //    Console.WriteLine(circle.CalculateArea());
        //}// Output: ~78.54
        #endregion
    }
}
