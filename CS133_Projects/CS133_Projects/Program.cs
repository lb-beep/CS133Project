using System;
using System.Collections;

namespace CS133_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myMultiDimensionalArray = new int[10, 10];

            for (int y=0; y<10; y++)
            {
                for(int x=0; x<10; x++)
                {
                    myMultiDimensionalArray[x, y] = x + 1 * (y + 1);
                }
            }

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.Write(myMultiDimensionalArray[x, y] + " ");
                }

                Console.WriteLine("");
            }

        }



    }
}

