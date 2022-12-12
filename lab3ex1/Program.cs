using System;

namespace lab3ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 1
            //Scrieti o functie care va calcula suma cifrelor unui numar.

            int adunare01 = Adunare(6, 4);

            static int Adunare(int x, int y)
            {
                return x + y;
            }

            Console.WriteLine(adunare01);
        }
    }
}
