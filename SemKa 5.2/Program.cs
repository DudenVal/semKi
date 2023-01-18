// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}
int[] array = new int[5];
array = FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.Write(string.Join(",", array));
System.Console.WriteLine("Число: ");
int numb = Convert.ToInt32(Console.ReadLine());
bool isOk = false;

for (int i = 0; i < array.Length; i++)
{
    if (numb == array[i])
    {

        isOk = true;
        break;
    }
}
if (isOk)
{
    System.Console.WriteLine(" Нашел");
}
else
{
    System.Console.WriteLine(" Не нашел");
}

