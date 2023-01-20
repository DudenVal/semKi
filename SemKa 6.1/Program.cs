// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

void FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2, 99);
    }
}

void ReverseArray(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[0] + array[1] > array[2] && array[0] + array[2] > array[1] && array[1] + array[2] > array[0])
        {
            System.Console.WriteLine("True");
        }
        else
        {
            System.Console.WriteLine("False");
        }
        break;
    }
}
int[] array = new int[3];

FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.Write(string.Join(", ", array));
System.Console.WriteLine();
ReverseArray(array);
Console.Write("Вывод: ");
Console.Write(string.Join(", ", array));