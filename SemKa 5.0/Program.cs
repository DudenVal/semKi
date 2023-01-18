// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

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

int sumPositive = 0;
int sumNegative = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sumPositive += array[i];
    }
    else
    {
        sumNegative+=array[i];
    }
}
System.Console.WriteLine();
Console.Write($" Сумма отрицательный чисел = {sumNegative}, Сумма положительных чисел = {sumPositive} ");