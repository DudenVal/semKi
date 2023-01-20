// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Enter b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double tochka = 0;
double x = 0;

if (b1 == b2 && k1 == k2) System.Console.WriteLine("Прямые совпадают");
else if (k1 == k2) System.Console.WriteLine("Прямые параллельны");
else
{
    x = (b2 - b1) / (k1 - k2);
    tochka = (k1 * (b2 - b1)) / (k1 - k2) + b1;

    System.Console.WriteLine($"(" + x + "; " + tochka + ")");
}
