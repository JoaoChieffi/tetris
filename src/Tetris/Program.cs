using System;

namespace Tetris
{
    class Program
    {
        static private int _score = 0;

        static void Main(string[] args)
        {
            Console.WriteLine();

            for (int i = 0; i < 25; i++)
            {
                Console.Write("#");
                Console.Write("\t\t\t");
                Console.WriteLine("#");
                if (i == 0)
                {
                    Console.Write("#");
                    Console.Write("\t\t\t");
                    Console.Write("#");
                    Console.Write("\t");
                    Console.WriteLine("SCORE: " + _score);
                }
            }


            for (int i = 0; i < 25; i++)
            {
                Console.Write("#");
            }

            Console.ReadKey();
        }
    }
}
