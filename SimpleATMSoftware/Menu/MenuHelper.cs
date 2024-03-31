namespace SimpleATMSoftware.Menu
{
    public static class MenuHelper
    {
        public static int CheckUserInputForDigits(ref int input, int digitsCount)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.Clear();
                    Console.WriteLine($"You enter an invalid number, please enter {digitsCount}-digit number:");
                }
                if (input.ToString().Length != digitsCount)
                {
                    Console.Clear();
                    Console.WriteLine($"Please enter {digitsCount}-digit number:");
                }
                else break;
            }

            return input;
        }

        public static long CheckUserInputForDigits(ref long input, int digitsCount)
        {
            while (true)
            {
                if (!long.TryParse(Console.ReadLine(), out input))
                {
                    Console.Clear();
                    Console.WriteLine($"You enter an invalid number, please enter {digitsCount}-digit number:");
                }
                if (input.ToString().Length != digitsCount)
                {
                    Console.Clear();
                    Console.WriteLine($"Please enter {digitsCount}-digit number:");
                }
                else break;
            }

            return input;
        }

        public static decimal CheckUserInputForDigits(ref decimal input)
        {
            while (!decimal.TryParse(Console.ReadLine(), out input))
            {
                Console.Clear();
                Console.WriteLine($"You enter an invalid number, please enter sum:");
            }
            return input;
        }

        public static void CheckUserTransactionsLimit()
        {
            Console.WriteLine("Sorry, you reached limit for today. " +
                "Total transactions limited to ten per day. " +
                "Please, try tomorrow.");
            Console.ReadKey();
        }

        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
        }
    }
}
