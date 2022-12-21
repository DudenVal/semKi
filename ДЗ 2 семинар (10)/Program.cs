//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int[] array = { 100, 456, 782};

int n = array.Length;
int index = 1;
Console.WriteLine(index);

// ----------------Другое решение----------------------------

// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Ваше случайное число: {number} ");

// int digit1 = number % 100;
// int digit2 = digit1 / 10;

// Console.WriteLine("Второе число по вашему запросу: " + digit2);
