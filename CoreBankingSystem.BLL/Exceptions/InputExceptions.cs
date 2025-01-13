namespace CoreBankingSystem.BLL.Exceptions
{
    public class InputExceptions : Exception
    {
        public static void PrintNullOrWhiteSpaceExceptionMessage(object propertyType)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                $"Please be informed that you can't enter white space or empty string in {nameof(propertyType)}\n" +
                $"You should provide proper {nameof(propertyType)}");
            Console.ResetColor();

            Task.Delay(1500).Wait();        
        }

        public static void PrintLengthExceptionMessage(object propertyType, int minimumLength, int maximumLength)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                $"Please be informed that {nameof(propertyType)} length should be minimum of {minimumLength} " +
                $"and maximum of {maximumLength}");
            Console.ResetColor();

            Task.Delay(1500).Wait();
        }

        public static void PrintNotValidInputExceptionMessage(object propertyType, bool isDigit = false,
            bool isUppercase = false, bool isLowercase = false, bool isSpecialCharacter = false)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            string message =
                $"Please be informed that {nameof(propertyType)} should contain";

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
