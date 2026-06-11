namespace DesignPatterns
{
    public class Singleton
    {
        //Ensures only one instance of a class exists and provides a global point of access to it.
        private static Singleton? _instance;
        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello World from Singleton!");
        }

        //public static void Main(string[] args)
        //{
        //    // Get the only instance of Singleton
        //    Singleton singleton = Singleton.GetInstance();
        //    // Show the message
        //    singleton.ShowMessage();

        //    Singleton.GetInstance().ShowMessage();
        //}
    }
}
