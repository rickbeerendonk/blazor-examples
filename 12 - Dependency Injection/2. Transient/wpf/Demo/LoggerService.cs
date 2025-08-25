// European Union Public License version 1.2
// Copyright © 2020 Rick Beerendonk

using System.Windows;

namespace Demo;

using System;

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
        MessageBox.Show($"{message} [logger: {this.id}]");
    }
}
