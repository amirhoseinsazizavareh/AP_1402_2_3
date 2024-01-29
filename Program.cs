using System;

class Program
{
    static void Main()
    {
        int number;

       
        Console.Write("Please enter a four-digit number: ");
        number = Convert.ToInt32(Console.ReadLine());

       
        int sum = 0;
        int tempNumber = number;
        while (tempNumber > 0)
        {
            int digit = tempNumber % 10;
            sum += digit;
            tempNumber /= 10;
        }

       
        Console.WriteLine("The sum of the digits of the entered number: " + sum);
    }
}