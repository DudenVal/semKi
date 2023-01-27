// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Enter your number: ");
int N = Convert.ToInt32(Console.ReadLine());
int cost = 0;
if (N % 2 == 0)
{
    cost = N % 2;
    Console.WriteLine("Да " + cost);
}
else
{
    cost = N % 2;
    Console.WriteLine("Нет " + cost);
}
