﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillArrayWithRandom(int[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}

void NewMatrix(int[,] array, int rows, int columns)
{

    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];

        }
        Console.WriteLine($"Среднее арифметическое столбце {j+1} = {Math.Round(sum / rows, 2)}");
    }

}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArrayWithRandom(matrix, m, n);
NewMatrix(matrix, m, n);