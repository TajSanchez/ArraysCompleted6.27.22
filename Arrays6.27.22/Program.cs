using System;
using System.Collections.Generic;

namespace Arrays6._27._22
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateGrid();

            Console.ReadKey();

        }

        public static void CreateGrid()
        { 
            int width = 20;
            int height = 20;

            int[,] grid = new int[width, height];
            
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Console.Write(grid[x, y] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
