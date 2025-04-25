// European Union Public License version 1.2
// Copyright © 2020 Rick Beerendonk

using System.Windows;

namespace Demo;

public class LoggerService
{
    private static int uniqueId;

    private readonly int id = ++uniqueId;

    public void Info(string message)
    {
        MessageBox.Show($"{message} [logger: {id}]");
    }
}
