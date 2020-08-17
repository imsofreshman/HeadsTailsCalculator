using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double fej = 0;
            double iras = 0;
            int feldobas = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[feldobas];
            Console.WriteLine("Kerem tippeljen adja meg hány feldobás legyen");
            for (int i = 0; i < feldobas; i++)
            {
                array[i] = random.Next(0, 2);
            }
            foreach (var item in array)
            {
                if (item == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(" F ");
                    fej++;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write(" Í ");
                    iras++;
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\nFej: {0} \t Iras {1}"
                , Math.Round((fej / array.Length) * 100, 2)
                , Math.Round((iras / array.Length) * 100, 2));
            Console.ReadKey();
        }
    }
}
