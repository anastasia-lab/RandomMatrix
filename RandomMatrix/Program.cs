using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравсвуйте. \nЗадайте размер массива.\n");

            Console.Write("Количество строк: ");
            int UserArrayString = int.Parse(Console.ReadLine());
            Console.Write("Количество столцов: ");
            int UserArrayColumn = int.Parse(Console.ReadLine());

            int[,] UserArray = new int[UserArrayString, UserArrayColumn];
            Random rnd = new Random();
            int summ = 0;

            Console.WriteLine("\nСозданный массив:\n");

            for (int i = 0; i < UserArrayString; i++)
            {
                for (int j = 0; j < UserArrayColumn; j++)
                {
                    UserArray[i, j] = rnd.Next(100);
                    summ = summ + UserArray[i, j];
                    Console.Write($"| {UserArray[i,j]} |");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма элементов: {summ}");

            Console.ReadKey();
        }
    }
}
