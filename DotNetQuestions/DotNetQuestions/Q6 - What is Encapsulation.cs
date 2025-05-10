namespace DotNetQuestions
{
    public class Encapsulation
    {
        #region Using Access Modifiers
        public class BankAccount
        {
            private double _balance; // Private field Hidden

            public double GetBalance()
            {
                return _balance;
            }

            public void Deposit(double amount)
            {
                Console.WriteLine(_balance += amount);
            }

            //static void Main()
            //{
            //    var account = new BankAccount();
            //    account.Deposit(1000);
            //    Console.WriteLine($"Balance: {account.GetBalance()}"); // Output: 500
            //    // account._balance = 1000; // Error: _balance is private!
            //}
        }
        #endregion

        #region Read Only and Write Only Properties
        public class Employee
        {
            public string EmployeeId { get; } // Only get property 
            private string _password; // private field
            public string Password { set => _password = value; } // only set the password

            public Employee(string id)
            {
                EmployeeId = id;
            }
            //static void Main()
            //{
            //    Employee emp = new Employee("E123");
            //    emp.Password = "secret";
            //    Console.WriteLine($"ID: {emp.EmployeeId}"); // Output: E123
            //    // Console.WriteLine(emp.Password); // Error: No getter!
            //}
        }
        #endregion

        #region Using Methods Instead of Direct Field Access
        public class Account
        {
            private double Balance { get; set; }

            public void Deposit(double amount)
            {
                if (amount <= 0)
                    throw new ArgumentException("Invalid Deposit");
                Balance += amount;
            }

            public double GetBalance()
            {
                return Balance;
            }

            //static void Main(string[] args)
            //{ 
            //    Account account = new Account();
            //    account.Deposit(100);
            //    Console.WriteLine($"Balance :{account.GetBalance()}");
            //}
        }
        #endregion

        #region Interface Encapsulation
        public interface ILogger
        {
            void Log(string message);  // No implementation details
        }

        public class FileLogger : ILogger
        {
            public void Log(string message)
            {
                File.WriteAllText("log.txt", message);
            }

            static void Main(string[] args)
            {
                FileLogger logger = new FileLogger(); // ← Swap to ConsoleLogger to change behavior

                logger.Log("User logged in");
                logger.Log("Order placed");

                Console.WriteLine("Check 'log.txt' for output!");
            }
        }
        #endregion
    }
}

