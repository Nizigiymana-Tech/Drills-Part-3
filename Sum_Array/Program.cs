using System;

class Program
{
    static void Main()
    {

        static int CalculateSum(int[] numbers)
        {
            int Total = 0;

            foreach (int num in numbers)
            {
                Total += num;
            }

            return Total;
        }

        int[] NumbersEqual100 = [15, 20, 45, 15, 5];

        Console.WriteLine(CalculateSum(NumbersEqual100));
    }
}