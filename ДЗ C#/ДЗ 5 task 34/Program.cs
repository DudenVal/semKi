// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
// ------------Задаем заполнение массива------------
int[] FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
int[] array = new int[5];
array = FillArrayWithRandom(array);

Console.Write("Ваш случайный массив: ");
Console.Write(string.Join(",", array));

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0) 
    {
        count++;
    }
}
System.Console.WriteLine(" ");
System.Console.WriteLine("Количество четных чисел = " + count);
