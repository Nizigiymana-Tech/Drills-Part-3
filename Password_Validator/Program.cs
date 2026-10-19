using System;

class Program
{
    static void Main()
    {
        static bool IsValidPassword(string Password)
        {
            if (Password.Length < 8) {
                return false;
            }

            if (string.IsNullOrWhiteSpace(Password))
            {
                return false;
            }

            if (Password.Any(char.IsWhiteSpace))
            {
                return false;
            }

            return true;
        }

        Console.WriteLine(IsValidPassword("ILoveIceCream123"));
        Console.WriteLine(IsValidPassword("I LOVE ICE CREAM 123"));
        Console.WriteLine(IsValidPassword("ILOVEIC"));
    }
}