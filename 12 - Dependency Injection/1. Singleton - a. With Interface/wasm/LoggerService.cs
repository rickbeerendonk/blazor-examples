using System;

namespace DependencyInjection_Singleton_WithInterface
{
    public interface ILogger {
        void Info(string message);
    }

    public class LoggerService : ILogger
    {
        private static int uniqueId = 0;

        private readonly int id;

        public LoggerService()
        {
           this.id = ++LoggerService.uniqueId;
        }

        public void Info(string message)
        {
            Console.WriteLine($"{message} [logger: {this.id}]");
        }
    }
}