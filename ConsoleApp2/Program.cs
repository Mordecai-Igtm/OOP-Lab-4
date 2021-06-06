using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Завдання 2.Не парні елементи
//Створити масив цілих чисел розміром в N елементів та заповнити його
//випадковими значеннями від -2N до 2N. Знайти всі не парні елементи на не
//парних позиціях та записати в новий масив. Вивести обидва масиви на екран.
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var rand = new Random();
            Console.WriteLine("Your number: ");
            var n = Console.ReadLine();
            int N = int.Parse(n);
            int Nm = (N * -2);
            int Np = (N * 2);
            int[] arrayRandom = new int[N];
            // Generate and display 5 random integers from 50 to 100.
            Console.WriteLine($"{N} random integers between -2*{N}({Nm}) to 2*{N}({Np}): \n");
            Console.Write("\n Index: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write("\t");
                Console.Write("[" + (i+1).ToString() + "]");
            }
            Console.WriteLine();
            Console.Write("\n arrayRandom: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write("\t");
                arrayRandom[i] = rand.Next(Nm, Np+1);
                Console.Write(arrayRandom[i]);
                
            }

            Console.Write("\n arrayOdds: ");
            for (int i = 0; i < N; i += 2) 
            {
                Console.Write("\t");
                if (Math.Abs(arrayRandom[i]) % 2 == 1)
                {
                    Console.Write("\t");
                    Console.Write(arrayRandom[i]);
                }
               
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
