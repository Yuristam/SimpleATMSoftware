namespace CoreBankingSystem.CMD.Exceptions
{
    public class InputExceptions : Exception
    {
        public static void PrintNullOrWhiteSpaceExceptionMessage(string propertyType)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                $"Please be informed that you can't enter white space or empty string in {propertyType}\n" +
                $"You should provide proper {propertyType}");
            Console.ResetColor();

            Task.Delay(1500).Wait();
        }

        public static void PrintLengthExceptionMessage(string propertyType, int minimumLength, int maximumLength)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                $"Please be informed that {propertyType} length should be minimum of {minimumLength} " +
                $"and maximum of {maximumLength}");
            Console.ResetColor();

            Task.Delay(1500).Wait();
        }

        public static void PrintNotValidInputExceptionMessage(string propertyType, bool isDigit = false,
            bool isUppercase = false, bool isLowercase = false, bool isSpecialCharacter = false)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            string message =
                $"Please be informed that {propertyType} should contain";

            if (isDigit) message += " at least one digit,";
            if (isUppercase) message += " at least one uppercase letter,";
            if (isLowercase) message += " at least one lower case letter,";
            if (isSpecialCharacter) message += " at least one special symbol,";

            Console.WriteLine(message);
            Console.ResetColor();

            Task.Delay(1500).Wait();
        }
    }
}
