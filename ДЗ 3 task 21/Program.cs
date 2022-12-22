// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2


//---------------------------------------Для координатов первой точки---------------------------------------
Console.Write("Ваша переменная X1: ");
double X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ваша переменная Y1: ");
double Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ваша переменная Z1: ");
double Z1 = Convert.ToInt32(Console.ReadLine());
//---------------------------------------Для координатов второй точки---------------------------------------
Console.Write("Ваша переменная X2: ");
double X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ваша переменная Y2: ");
double Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ваша переменная Z2: ");
double Z2 = Convert.ToInt32(Console.ReadLine());

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

double distance = Math.Round(Math.Sqrt(Math.Pow(X1 - X2, 2)+ Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2)), 2);

Console.WriteLine("Расстояние между точками в 3D пространстве = " + distance);