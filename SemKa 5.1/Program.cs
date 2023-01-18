﻿// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

int[] array = new int[5];      // 5 элементов массива создаются из нулей и метод выше это заполнение готового массива.
array = FillArrayWithRandom(array);         // вызов массива.
Console.Write("Ваш случайный массив: ");
Console.Write(string.Join(",", array));

for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
}
System.Console.WriteLine();
Console.Write(string.Join(",", array));