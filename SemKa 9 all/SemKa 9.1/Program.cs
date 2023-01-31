// // Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

void printMToN(int numb, int numb2)
{
    if (numb < numb2) return;
    else{
    printMToN(numb - 1, numb2);
    Console.Write(numb + " ");
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());

if(n > m) printMToN(n, m);
else if(n == m) Console.Write(n);
else printMToN(m, n);
