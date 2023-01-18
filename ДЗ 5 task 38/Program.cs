// //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.7; 7.2; 2.1; 7.8] -> 5.7

double[] FillArrayWithRandom(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();          
    }
    return array;
}
double[] array = new double[5];
array = FillArrayWithRandom(array);

Console.Write("Ваш случайный массив: ");
Console.Write(string.Join(", ", array));
///////////////////////////////////////////////
double Diff = 0;
double min = 1000;
double max = 0;


for (int i = 0; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];

    }
    else if(min > array[i])
    {
        min = array[i];
    }
}
Diff = max - min;


System.Console.WriteLine(" ");
System.Console.WriteLine("Максимальное число = " + max);
System.Console.WriteLine("Минимальное число = " + min);
System.Console.WriteLine(" ");
System.Console.WriteLine("Разница = " + Diff);