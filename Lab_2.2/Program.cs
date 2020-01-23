using System;

namespace Lab_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int num;
            bool worked;
            string userContinue = null;
            int square;
            int cubed;

            Console.WriteLine("Learn your squares and cubes!");
            do
            {
                do
                {
                    Console.Write("\nEnter an integer:");
                    input = Console.ReadLine();
                    worked = int.TryParse(input, out num);

                    if (num >= (Math.Pow(int.MaxValue, (double)1 / 3)))
                    {
                        Console.WriteLine("That number cubed is larger than an integer. Please enter a smaller number");
                    }
                    if (worked == false)
                    {
                        Console.WriteLine("Let's try again.");
                        Console.Write("\nEnter a positive whole number: ");
                        input = Console.ReadLine();

                        worked = int.TryParse(input, out num);
                    }
                    else if (num <= 0)
                    {
                        if (num == 0)
                        {
                            Console.WriteLine("\nSilly goose, zero isn't a positive number!");
                        }
                        else 
                        {
                            Console.WriteLine("\nThat wasn't a positive number!");
                        }
                    }

                } while ((worked == false) || (num >= (Math.Pow(int.MaxValue, (double)1 / 3))));


                Console.WriteLine($"\nNumber\t\tSquared\t\tCubed");
                string equalString = new string('=', 7);
                Console.WriteLine($"{equalString}\t\t{equalString}\t\t{equalString}"); 

                for (int i = 1; i <= num; i++)
                {

                    square = i * i;
                    cubed = i * i * i;

                    Console.WriteLine($"{i}\t\t{square}\t\t{cubed}");
                }

                Console.Write("\nWould you like to continue? (y/n) ");
                userContinue = Console.ReadLine().ToLower();
                Console.Clear();

            } while (userContinue != "n" || userContinue != "no");

            Console.WriteLine();
            Console.WriteLine("Thank you and see you again!");


        }
    }
}
