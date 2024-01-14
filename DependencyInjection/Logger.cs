namespace DependencyInjection;

class Logger : ILogger
{
    public void Log(string message)
    {
        System.Console.WriteLine($"Logging ... \n{message}");
    }
}
