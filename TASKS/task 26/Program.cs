// Задача 28: Напишите программу, которая принимает на вход число
//  N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

System.Console.WriteLine("Enter you number: ");
int numb = Convert.ToInt32(Console.ReadLine());

int N = 1;

for (int i = 1; i <= numb; i++)
{
    N *= i;
}
Console.WriteLine("Количество чисел = " + N);


// методом


int Sum(int number)
{
int sum = 1;
for(int i = 1; i <= number; i++)
{
sum *= i;
}
return sum;
}

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(A));
