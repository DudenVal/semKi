//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter u numb: ");
int Numb = Convert.ToInt32(Console.ReadLine());
string array = Convert.ToString(Numb);

Console.WriteLine("Second number: " + array[1]);

// ----------------Другое решение----------------------------

// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Ваше случайное число: {number} ");

// int digit1 = number % 100;
// int digit2 = digit1 / 10;

// Console.WriteLine("Второе число по вашему запросу: " + digit2);
