﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// System.Console.WriteLine("Enter you number: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// int Gnida = 0;                    // Долго маялся с кодом, а решение было простым, нужно было только переменную добавить)
// int sum = 0;
// while (numb > 0)
// {
//     Gnida = numb % 10;
//     numb = numb / 10;
//     sum += Gnida;
// }
// Console.Write(sum + " ");

// --------------------------Методом----------------


System.Console.WriteLine("Введите переменую A ");
int numb = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int Gnida = 0;
Console.WriteLine(Sum(numb));
int Sum(int number)
{
    int N = 1;
    while (numb > 0)
    {
        Gnida = numb % 10;
        numb = numb / 10;
        sum += Gnida;
    }
    return sum;
}

