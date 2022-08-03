using System;

namespace ConsoleApp2
{
    class Program
    {
        static void DrawHourglass(int n)
        {
            int halfOfElement = n / 2;
            int switchVariable = 1;

            for (int i = 1; i <= n; i += switchVariable)
            {
                if (i > halfOfElement)
                {
                    switchVariable = -1;
                    if (n % 2 == 0)
                    {
                        continue;
                    }
                }
                if (i == 0)
                {
                    break;
                }
                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 0; k <= (n - i * 2) + 1; k++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();



            }

        }
        static void Main(string[] args)
        {
            Console.Write("Insert Hourglass Size ");
            var hourglasscount = Convert.ToInt32(Console.ReadLine());
            DrawHourglass(hourglasscount);
        }
    }
}
