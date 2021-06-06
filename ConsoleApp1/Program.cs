using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 3.Сума діагоналей
//Створити масив розміром N на N. Заповнити його значеннями від -20 до
//20. Обрахувати суму елементів головної та допоміжної діагоналі.
//Вивести на екран масив та два значення суми.
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dimension of the array: ");
            var n = Console.ReadLine();
            int N = int.Parse(n);
            var r = new int[N,N];
            Random rnd = new Random();
            Console.WriteLine("Your array: \n");
            for (int i = 0; i < N; i++) 
            {
                for (int j = 0; j < N; j++)
                {
                    r[i,j] = (rnd.Next(-21, 21));
                    
                    Console.Write("{0,3}", r[i, j]);
                }
            } 

            
            var sumMain = 0;
            var sumHelp = 0;

            for (int i = 0; i < N; i++)
            {
                sumMain += r[i, i];
                sumHelp += r[i, N - 1 - i];
            }
            Console.WriteLine("\n");
            Console.WriteLine($"First diagonal: {sumMain}");
            Console.WriteLine($"Second diagonal: {sumHelp}");

            Console.ReadKey();
        }
    }
}
