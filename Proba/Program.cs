using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsAndTailsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double head = 0;
            double tail = 0;
            Console.WriteLine("How many games you want to play?");
            int game;
            while (!int.TryParse(Console.ReadLine(), out game))
            {
                Console.WriteLine("Try Again!");
            }
            int[] array = new int[game];
            for (int i = 0; i < game; i++)
            {
                array[i] = random.Next(0, 2);
            }
            foreach (var item in array)
            {
                if (item == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(" H ");
                    head++;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write(" T ");
                    tail++;
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\nHeads: {0} \nTails: {1}"
                , Math.Round((head / array.Length) * 100, 2)
                , Math.Round((tail / array.Length) * 100, 2));
            Console.WriteLine("\n\nPress a key to exit");
            Console.ReadKey();

        }
    }
}
