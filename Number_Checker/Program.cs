using System;

class Program
{
    static void Main()
    {
        static bool IsEven(int number)
        {
            if (number % 2 == 0) {
                return true;
            } else {
                return false;
            }
        }

        Console.WriteLine(IsEven(2));
        Console.WriteLine(IsEven(3));
    }
}