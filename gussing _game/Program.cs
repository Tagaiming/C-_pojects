using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int robot = random.Next(1, 10);
            Console.WriteLine("$$$$$Number gussing game$$$$");

            int user = 0;
            do
            {
                Console.WriteLine("Enter your number which under 1-10");
                string input = Console.ReadLine() ?? "0";
                try
                {
                    user = int.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                if (user == robot)
                {
                    Console.WriteLine("You Won the game\n");
                }
                else if (user > robot)
                {
                    Console.WriteLine("Number is bigger! ");
                }
                else if (user < robot)
                {
                    Console.WriteLine("Number is Small! ");
                }
                else
                {
                    Console.WriteLine("Try again\n");
                }



            } while (user != robot);
        }
    }
}
