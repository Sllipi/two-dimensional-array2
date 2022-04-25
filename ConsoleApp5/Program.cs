using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t" + @"Задача:
Дан двумерный массив.
Вычислить сумму второй строки и произведение первого столбца.
Вывести исходную матрицу и результаты вычислений.");

            Random rand1 = new Random();
            int numberOfRows = rand1.Next(3, 9);
            int numberOfColumns = rand1.Next(3, 9);
            int[,] array = new int[numberOfRows, numberOfColumns];
            int sumOfSecondLine = 0;
            var productOfFirstLine = 1;
            Console.WriteLine($"Колличество строк = {numberOfRows}, колличество столбцов = {numberOfColumns}");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand1.Next(1, 100);
                    Console.Write($"{array[i, j]} ");
                    if (i == 1)
                    {
                        sumOfSecondLine += array[i, j];
                    }
                    if (j == 0)
                    {
                        productOfFirstLine *= array[i, j];
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма второй строки = {sumOfSecondLine}, произведение первой столбца = {productOfFirstLine}");
        }
    }
}
