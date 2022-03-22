using Calculator;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;

public class Program
{
    public static void Main()
    {
        ILoggerFactory loggerFactory = LoggerFactory.Create(config =>
        {
            config.AddConsole();
        });
        ILogger<Calculate> logger = loggerFactory.CreateLogger<Calculate>();

        Calculate c = new Calculate(logger);
        Console.WriteLine(c.Multiply(4, 5));
    }
}
