// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArrayWithRandom(double[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Math.Round(new Random().Next(-10, 11)+ new Random().NextDouble(), 1);
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Enter u number m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter u number n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m, n];
FillArrayWithRandom(matrix, m, n);