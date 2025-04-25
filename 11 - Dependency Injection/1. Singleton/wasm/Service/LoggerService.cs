namespace DependencyInjection_Singleton;

public class LoggerService
{
    private static int uniqueId;

    private readonly int id = ++uniqueId;

    public void Info(string message)
    {
        Console.WriteLine($"{message} [logger: {id}]");
    }
}
