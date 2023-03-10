// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 49 2
// 5 9 2 3
// 64 4 4 4

void FillArrayWithRandom(int[,] matrix, int m, int n)
{
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = new Random().Next(-10, 11);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
void NewMatrix(int[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = matrix[i, j] *  matrix[i, j];
            }
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
System.Console.WriteLine("Enter u number m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter u number m: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArrayWithRandom(matrix, m, n);
NewMatrix(matrix, m, n);