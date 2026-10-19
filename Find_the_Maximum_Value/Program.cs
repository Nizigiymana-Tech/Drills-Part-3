using System;

class Program
{
    static void Main()
    {
        static int FindMax(int[] Numbers)
        {
            return Numbers.Max();
        }

        int[] Numbe = [15, 20, 45, 15, 5];
        Console.WriteLine(FindMax(Numbe));
    }
}