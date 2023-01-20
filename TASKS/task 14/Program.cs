// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите переменную X: ");
int X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите переменную Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if(X > 0 && Y > 0)
{
    Console.WriteLine("Точка находиться в первой четверти!");
}
else if(X < 0 && Y > 0)
{
    Console.WriteLine("Точка находиться во второй четверти!");
}
else if(X < 0 && Y < 0)
{
    Console.WriteLine("Точка находиться в третьей четверти!");
}
else
{
    Console.WriteLine("Точка находиться в четвертой четверти!");
}