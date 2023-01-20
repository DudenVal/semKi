// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Enter u number: ");
int NumbA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter u number: ");
int NumbB = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter u number: ");
int NumbC = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter u number: ");
int NumbD = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter u number: ");
int NumbG = Convert.ToInt32(Console.ReadLine());

int count = 0;
if(NumbA > 0) count++;
if(NumbB > 0) count++;
if(NumbC > 0) count++;
if(NumbD > 0) count++;
if(NumbG > 0) count++;

System.Console.WriteLine($"Количество положительных чисел = " + count);

//Я надеюсь, ничего, если я решил таким легким способом?)
