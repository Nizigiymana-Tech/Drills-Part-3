using System;

class Program
{
    static void Main()
    {
        static void printWelcome(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        printWelcome("Apple");
        printWelcome("Bananas");
    }
}