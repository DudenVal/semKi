﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (без использования Math.Pow)

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите переменую A ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите переменую B ");
int B = Convert.ToInt32(Console.ReadLine());
int N = 1;
for (int i = 1; i <= B; i++)
{
    N *= A; // N = N * i;
}
System.Console.WriteLine(N);

