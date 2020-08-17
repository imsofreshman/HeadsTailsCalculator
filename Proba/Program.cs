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
            int game = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[game];
            Console.WriteLine("How many games you want to play?");
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
            Console.WriteLine("\n\nHeads: {0} \t Tails {1}"
                , Math.Round((head / array.Length) * 100, 2)
                , Math.Round((tail / array.Length) * 100, 2));
            Console.ReadKey();
        }
    }
}
