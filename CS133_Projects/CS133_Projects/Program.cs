using System;

namespace CS133_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] multiplicationTable = new int[9][];
            for (int line = 1; line <=9; line++)
            {
                multiplicationTable[line - 1] = new int[line];

                for (int col = 1; col <=line; col++)
                {
                    multiplicationTable[line - 1][col - 1] = line * col;
                }
            }
            for (int line = 1; line <=9; line++)
            {
                for (int col=1; col <= line; col++)
                {
                    Console.Write((col + "*" + line + "=" + multiplicationTable[line - 1][col - 1]).PadRight(8));
                }
                Console.WriteLine();
            }
        }
    }
}
