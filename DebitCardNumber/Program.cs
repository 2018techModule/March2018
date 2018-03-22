using System;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //input the first part of number
            int firstNumber = int.Parse(Console.ReadLine());
            //input the second part of number
            int secondNumber = int.Parse(Console.ReadLine());
            //input the third part of number
            int thirdNumber = int.Parse(Console.ReadLine());
            //input the fourth part of number
            int lastNumber = int.Parse(Console.ReadLine());
            //write the number in the console
            Console.WriteLine($"{firstNumber:D4} {secondNumber:D4} {thirdNumber:D4} {lastNumber:D4}");
        }
    }
}
