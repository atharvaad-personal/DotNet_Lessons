namespace Lessons_DotNetC_
{
    //👎 Robot doesn't need Eat(), but it's forced to implement it.ISP is violated.
    public class Robot : IRobot
    {
        public void Work()
        {
            Console.WriteLine("Robot is working");
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }

    public interface IRobot
    {
        void Work();

        void Eat();
    }

    //✅ Now each class only implements what it needs.ISP is satisfied.
    public class RobotISP : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robot is working");
        }
    }

    public class Human : IEatable
    {
        public void Eat()
        {
            Console.WriteLine("Human is Eating");
        }
    }

    public interface IWorkable
    {
        void Work();
    }

    public interface IEatable
    {
        void Eat();
    }
}
