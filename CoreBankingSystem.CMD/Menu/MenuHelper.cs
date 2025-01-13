namespace CoreBankingSystem.CMD.Menu
{
    public static class MenuHelper
    {
        private static DateTime _dayTime = DateTime.Now;

        public static void GreetingUser(string userName)
        {
            if (_dayTime.Hour >= 6 && _dayTime.Hour <= 12)
                Console.WriteLine($"Good Morning, {userName}!");
            else if (_dayTime.Hour >= 12 && _dayTime.Hour <= 20)
                Console.WriteLine($"Good Afternoon, {userName}!");
            else
                Console.WriteLine($"Good Evening, {userName}!");
        }
    }
}
