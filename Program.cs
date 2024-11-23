using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть натуральне число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Число має бути натуральним (більше 0).");
            Console.ReadKey();
            return;
        }
        int digitCount = CountDigits(number);
        Console.WriteLine($"Кількість цифр у числі {number}: {digitCount}");
        Console.ReadKey();
    }

    static int CountDigits(int n)
    {
        int count = 0;
        while (n > 0)
        {
            n /= 10;
            count++;
        }
        return count;
    }
}
