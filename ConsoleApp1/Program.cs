using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomObject = new Random();
            Int64 randomDirection;
            while (true)
            {
                Console.WriteLine("Enter a number of steps");
                Int64 n = Int64.Parse(Console.ReadLine());
                for (Int64 i = 0; i < n; i++)
                {
                    randomDirection = randomObject.Next(1, 5);

                    if (randomDirection == 1)
                    {
                        Console.WriteLine("Walk right");
                    }
                    if (randomDirection == 2)
                    {
                        Console.WriteLine("Walk left");
                    }
                    if (randomDirection == 3)
                    {
                        Console.WriteLine("Walk up");
                    }
                    if (randomDirection == 4)
                    {
                        Console.WriteLine("Walk down");
                    }
                }
            }
        }
    }
}