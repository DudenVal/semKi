// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Ваше желаемое число: ");
double X1 = Convert.ToInt32(Console.ReadLine());
double i = 1;
while(i <= X1)
{
    double numb = Math.Pow(i, 2);
    Console.WriteLine(numb + " ");
    i++;
}

//////////////////////Решение через for()////////////////

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= number; i++)
{
    Console.Write(Math.Pow(i, 2) + " ");
}
