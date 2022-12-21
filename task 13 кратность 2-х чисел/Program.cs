// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите переменную а: ");
int a = Convert.ToInt32(Console.ReadLine());
int numbA = 7;
int numbB = 23;
int numbC = a / 7;
if(numbC / numbB >= 1)
    {

        Console.WriteLine("Да");
    }

else
    {
    Console.WriteLine("Нет");
    }

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());


if( a == b * b | b == a * a)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}



