// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int numbers = new Random().Next(100, 1000);
Console.WriteLine("Ваше случайное число " + numbers);
int digit1 = numbers/10;
int digit2 = numbers%10;

if (digit1 > digit2)
{
    Console.WriteLine("Первое число больше второго " + digit1);
}
else 
{
    Console.WriteLine("Второе число больше первого " + digit2);
}


// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98


// int number = new Random().Next(100, 999);
// Console.WriteLine($"Ваше случайное число: {number}");
// int digit1 = number/100;
// int digit2 = number%10;
// int new_number = digit1*10 + digit2;
// Console.WriteLine($"Ваше новое число число: {new_number}");




// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.WriteLine("Введите переменную а: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите переменную b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a % b == 0)
//     {
//         Console.WriteLine("Кратно");
//     }

// else
// {
//     int a = numb1 % numb2;
//     Console.WriteLine("они не кратны.");
//     Console.WriteLine(a);
// }
