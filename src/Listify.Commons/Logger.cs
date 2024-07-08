namespace Listify.Commons
{
    public class Logger
    {

        public static void LogError(string errorMessage)
        {
            Console.WriteLine($"[{DateTime.Now}] - ERROR: {errorMessage}");
        }

        public static void LogInformation(string errorMessage)
        {
            Console.WriteLine($"[{DateTime.Now}] - INF: {errorMessage}");
        }

        public static void LogWarning(string errorMessage)
        {
            Console.WriteLine($"[{DateTime.Now}] - WNG: {errorMessage}");
        }
    }
}
