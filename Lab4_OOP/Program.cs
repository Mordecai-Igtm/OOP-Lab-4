using System;

namespace Lab4_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            int N = int.Parse(n);
            int[] odd = new int[N];
            int Nm = (N * -2);
            int Np = (N * 2);
            Random rnd = new Random();

            for (int i = 0; i <= 10; i++);
            {
                Console.WriteLine("{0,8:N0}", rnd.Next(50, 101));
            }

            Console.ReadKey();
        }
    }
}
