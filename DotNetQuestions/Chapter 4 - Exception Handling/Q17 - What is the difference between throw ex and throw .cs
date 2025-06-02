namespace Chapter_4___Exception_Handling
{
    public class Q17___What_is_the_difference_between_throw_ex_and_throw
	{
		public static void DivideZeroByZero()
		{
			try
			{
				int i = 0;
				int j = 0;
				int k = i / j;
			}
			catch (Exception)
			{
				throw;
			}

		}

        static void Main(string[] args)
        {
            try
            {
                DivideZeroByZero();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
