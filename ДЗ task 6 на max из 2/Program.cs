// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите переменную а: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите переменную b: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;    //Код выеживался, требовал ввести значения max & min, пришлось выкручиваться.
int min = 0;    //Код выеживался, требовал ввести значения max & min, пришлось выкручиваться.

if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}

Console.WriteLine("Максимальное число равно: " + max);
Console.WriteLine("Минимальное число равно: " + min);
