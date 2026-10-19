using System;

class Program
{
    static void Main()
    {
        static void Countdown(int StartNumber)
        {
            while (StartNumber > 0)
            {
                Console.WriteLine(StartNumber);
                StartNumber -= 1;
                Thread.Sleep(1000);
            }

            Console.WriteLine("Liftoff!");
        }

        Countdown(10);
    }
}