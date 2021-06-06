using System;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 5];
            int x = 0, y = 0;

            Random r = new Random();
            while (y < 5)
            {
                int rand = r.Next(-50, 50);
                array[x, y] = rand;

                x++;
                if (x == 10)
                {
                    x = 0;
                    y++;
                }
            }
        }
    }
}
