// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.WriteLine("введи число повторений: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] Fibonachi = new int[count];

for (int i = 0; i < Fibonachi.Length; i++)
{
    if(i >= 2)
    {
        Fibonachi[i] = Fibonachi[i - 1] + Fibonachi[i - 2];
    }
    else if(i == 2 || i == 1) Fibonachi[i] = 1;
    else if(i == 0) Fibonachi[i] = 0;
}

Console.Write('[' + string.Join(',', Fibonachi) + ']');

// 2 Вариант

int[] Fibonacci(int a)
{
int[] arr = new int[a];
arr[0] = 0;
arr[1] = 1;
for(int i = 2; i < a; i++) {
arr[i] = arr[i - 2] + arr[i - 1];
}
return arr;
}

System.Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(string.Join(" ", Fibonacci(N)));