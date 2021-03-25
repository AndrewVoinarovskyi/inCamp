using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            int summa = MakeSumma(first, second);
            Console.WriteLine($"Summa all numbers between {first} {second} will be {summa}");

            Console.Write("Input number for looking factorial: ")
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = LookFact(number);
            Console.WriteLine($"Factorial of your number {factorial}");

            Console.Write("Input number of your item: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input your word when number with 1 in the end: ");
            string one = Console.ReadLine();
            Console.Write("Input your word when number with (2-4) in the end: ");
            string some = Console.ReadLine();
            Console.Write("Input your word for another situation: ");
            string many = Console.ReadLine();
            string pluralWord = PluralizeWord(count, one, some, many);
            Console.WriteLine(pluralWord);
        }

        static int MakeSumma(int First, int Second)
        {
            int sum = 0;
            for(int i = First; i <= Second; i++)
            {
                sum += i;
            }

            return sum;
        }

        static int LookFact(int num)
        {
            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact *= i;
            }

            return fact;
        }

        static string PluralizeWord(int num, string one, string some, string many)
        {
            string pluralized;
            if (num % 10 == 1 && num % 100 != 11)
            {
                pluralized = $"{num} {one}";
            }
            else if (num % 10 > 1 && num % 10 < 5 && (num < 5 || num > 15))
                {
                    pluralized = $"{num} {some}"; 
                }
                else
                {
                    pluralized = $"{num} {many}";
                }

            return pluralized;
        }
    }
}
