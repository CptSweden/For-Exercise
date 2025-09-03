namespace For_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Counting from 1 to 10");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("This is the even numbers between 2-20");

            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
            */

            /*
            Console.WriteLine("Please enter a number");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication table of {number}");

            for (int i = 1; i <= 10; i++)
            {
                int sum = number * i;

                Console.WriteLine($"{number} x {i} = {sum}");
            }
            */

            /*
            Console.WriteLine("Counting down from 10 to 1");

            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            */

            /*
            Console.WriteLine("This is all numbers from 1 to 100 added up");

            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine(sum);
            */

            /* 
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }
            */


            Console.WriteLine("Enter a number!");

            int sum = 1;
        
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number;  i++)
            {
                sum = sum * i;
            }

            Console.WriteLine($"{sum}");

        }

    }
}
