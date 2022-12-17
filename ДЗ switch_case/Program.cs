Console.WriteLine("Введите номер задания(от 1 до 4): ");
int DZNumber = Convert.ToInt32(Console.ReadLine());
switch (DZNumber)
{
    case 1:

        // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        // a = 5; b = 7 -> max = 7
        // a = 2 b = 10 -> max = 10
        // a = -9 b = -3 -> max = -3
        
        Console.WriteLine("Введите переменную а: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите переменную b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int max = 0;    //Код выеживался, требовал ввести значения max & min, пришлось выкручиваться.
        int min = 0;    //Код выеживался, требовал ввести значения max & min, пришлось выкручиваться.

        if (a > b)
        {
            max = a;
            min = b;
        }
        else
        {
            max = b;
            min = a;
        }

        Console.WriteLine("Максимальное число равно: " + max);
        Console.WriteLine("Минимальное число равно: " + min);
        ;
        break;

    case 2:

        // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        // 2, 3, 7 -> 7
        // 44 5 78 -> 78
        // 22 3 9 -> 22

        Console.WriteLine("Enter your number d: ");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your number e: ");
        int e = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your number f: ");
        int f = Convert.ToInt32(Console.ReadLine());
        int maxA = d;
        if (e > d && e > f)
        {
            maxA = e;
        }

        else if (f > d && f > e)
        {
            maxA = f;
        }

        Console.WriteLine("Максимально число: " + maxA);
        break;

    case 3:

        // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
        // (делится ли оно на два без остатка).
        // 4 -> да
        // -3 -> нет
        // 7 -> нет

        Console.WriteLine("Enter your number: ");
        int Na = Convert.ToInt32(Console.ReadLine());
        if (Na % 2 == 0)
        {

            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
        Console.Write(Na);
        break;

    case 4:
        // Задача 8: Напишите программу, которая на вход принимает число (N), 
        // а на выходе показывает все чётные числа от 1 до N.
        // 5 -> 2, 4
        // 8 -> 2, 4, 6, 8

        Console.Write("Введите ваше число: ");
        int Nb = Convert.ToInt32(Console.ReadLine());
        int i = 1;

        while (i <= Nb)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
            i++;
        }
        break;

    default:
        Console.WriteLine("Такого задания не существует");
        break;
}