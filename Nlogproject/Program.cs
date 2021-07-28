using System;

namespace NLogProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NLog");
            Addition addition = new Addition();
            addition.Add(10, 20);
        }
    }
}
