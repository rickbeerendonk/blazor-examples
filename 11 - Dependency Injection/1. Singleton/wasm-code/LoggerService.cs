using System;

namespace DependencyInjection_Singleton_Code
{
    public class LoggerService
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