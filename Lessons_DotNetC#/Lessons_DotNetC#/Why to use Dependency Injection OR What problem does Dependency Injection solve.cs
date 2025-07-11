using System.Web.Mvc;

namespace Lessons_DotNetC_
{
    public class MathStudent
    {
        public int GetStudentCount()
        {
            return 100;
        }
    }

    public class FirstController : Controller
    {
        public int Index()
        {
            MathStudent mathStudent = new MathStudent();
            return mathStudent.GetStudentCount();
        }
    }

    public class SecondController : Controller
    {
        public int Index()
        {
            MathStudent mathStudent = new MathStudent();
            return mathStudent.GetStudentCount();
        }
    }
}
