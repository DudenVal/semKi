// Math.Sqrt() - это нахождение квадратного корня
// Math.Pow(переменная, степень в которую нужно возвести) - это возведение в какую-то степень 
// Math.Round(переменная, цифры после запятой) - округление числа


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// AB = √(xb - xa)2 + (yb - ya)2


//For 1

Console.WriteLine("Введите номер X1: ");
double X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер Y1: ");
double Y1 = Convert.ToInt32(Console.ReadLine());

// For 2

Console.WriteLine("Введите номер X2: ");
double X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер Y2: ");
double Y2 = Convert.ToInt32(Console.ReadLine());

double numb = Math.Round(Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)), 2); // Можно поменять местами X2 и X1, и ничего не измениться.

Console.WriteLine("Ответ " + numb);