using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica;
            Random rand = new Random();
            tablica = new int[200];

            for (int i=0; i<tablica.Length; i++)
            {
                int random = rand.Next(1000);
                tablica[i] = random;
                Console.Write(tablica[i] + " ");
            }
            Console.ReadLine();

        }
    }
}
