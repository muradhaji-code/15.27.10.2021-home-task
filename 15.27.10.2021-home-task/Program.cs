using System;
using System.Text.RegularExpressions;

namespace _15._27._10._2021_home_task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 6
            //Console.Write("Enter number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Cube of {number} is {FindCube(number)}");
            #endregion

            #region Task 7
            //Console.Write("Enter number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Number of digits of {number} is {NumberOfDigits(number)}");
            #endregion

            #region Task 8
            //Console.Write("Enter number: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Sum of series for n={n} is {SumOfSeries(n)}");
            #endregion

            #region Task 9
            //Console.Write("Enter number: ");
            //int n = int.Parse(Console.ReadLine());
            //Pattern(n);
            #endregion

            #region Task 10
            string text = Console.ReadLine();
            Console.WriteLine($"Space count: {CountSpaces(text)}");
            #endregion
        }

        static int FindCube(int number)
        {
            return number * number * number;
        }

        static int NumberOfDigits(int number)
        {
            int count = 0;
            while (number != 0)
            {
                count++;
                number /= 10;
            }
            return count;
        }

        static int SumOfSeries(int n)
        {
            int temp = 2, sum = 0;
            while (n != 0)
            {
                sum += temp;
                temp = temp * 10 + 2;
                n--;
            }
            return sum;
        }

        static void Pattern(int n)
        {
            int i = 1;
            while (i <= n / 2)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                i++;
            }
            if (n % 2 == 0) i--;
            while (i > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                i--;
            }
        }

        static int CountSpaces(string text)
        {
            return Regex.Matches(text, @"\s").Count;
        }
    }
}
