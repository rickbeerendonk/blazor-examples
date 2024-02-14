using System;

namespace Demo;

public interface ILogger {
    void Info(string message);
}

public class LoggerService1 : ILogger
{
    private static int uniqueId = 0;

    private readonly int id;

    public LoggerService1()
    {
        id = ++uniqueId;
    }

    public void Info(string message)
    {
        Console.WriteLine($"{message} [logger1: {this.id}]");
    }
}

    
public class LoggerService2 : ILogger
{
    private static int uniqueId = 0;

    private readonly int id;

    public LoggerService2()
    {
        id = ++uniqueId;
    }

    public void Info(string message)
    {
        Console.WriteLine($"{message} [logger2: {this.id}]");
    }
}
