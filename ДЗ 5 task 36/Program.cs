// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 200);
    }
    return array;
}
int[] array = new int[7];
array = FillArrayWithRandom(array);

Console.Write("Ваш случайный массив: ");
Console.Write(string.Join(",", array));
int Sum = 0;
for (int i = 1; i < array.Length; i = i + 2)
{
    Sum += array[i];
}
System.Console.WriteLine(" ");
System.Console.WriteLine("Сумма = " + Sum);