namespace Chapter_7___Important_Keywords
{
    internal class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void GetStudent()
        {
            Console.WriteLine($"Id is {id} and name is {name}");
        }

        //static void Main(string[] args)
        //{
        //    Student student = new Student(1, "Atharva");
        //    student.GetStudent();
        //}
    }
}
