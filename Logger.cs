namespace GitExamApp
{
    public class Logger
    {
        public void LogError(string message)
        {
            System.Console.WriteLine($"[ERROR] {message}");
        }

        public void Log(string message)
        {
            System.Console.WriteLine($"[LOG] {message}");
        }
    }
}
