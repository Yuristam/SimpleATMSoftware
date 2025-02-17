namespace CoreBankingSystem.CMD.Menu
{
    public static class MenuHelper
    {
        private static DateTime _dayTime = DateTime.Now;

        public static void GreetingUser()
        {
            if (_dayTime.Hour >= 6 && _dayTime.Hour <= 12)
                Console.WriteLine($"Good Morning, user!");
            else if (_dayTime.Hour >= 12 && _dayTime.Hour <= 20)
                Console.WriteLine($"Good Afternoon, user!");
            else
                Console.WriteLine($"Good Evening, user!");
        }
    }
}
