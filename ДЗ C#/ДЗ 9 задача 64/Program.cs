// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
System.Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
System.Console.WriteLine("Enter u number: ");
int N = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int number, int SecondNumber)
{
    if (SecondNumber >= number + 1) return;
    PrintNumbers(number, SecondNumber + 1);
    System.Console.Write(SecondNumber + " ");
}
int SecondNumber = 1;
PrintNumbers(N, SecondNumber);