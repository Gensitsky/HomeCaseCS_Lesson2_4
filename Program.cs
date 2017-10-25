/*В двумерном массиве порядка M на N поменяйте
местами заданные столбцы.*/
using System;

namespace HomeCaseCS_Lesson2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = 4, N = 5;
            int[,] arr = new int[M, N];
            Random rnd = new Random();
            Console.WriteLine("Sourse array:");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    arr[i, j] = rnd.Next(10);
                    Console.Write(arr[i,j]+" | ");
                }
                Console.WriteLine();
            }
            Console.Write("\nEnter editable column: ");
            int editColumn = Convert.ToInt32(Console.ReadLine())-1;
            Console.Write("Enter portable column: ");
            int portColumn = Convert.ToInt32(Console.ReadLine())-1;
            int buffer;
            for (int i = 0; i < M; i++)
            {
                buffer = arr[i, editColumn];
                arr[i, editColumn] = arr[i, portColumn];
                arr[i, portColumn] = buffer;
            }
            
            Console.WriteLine("\nChanged array:");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(arr[i,j]+" | ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}