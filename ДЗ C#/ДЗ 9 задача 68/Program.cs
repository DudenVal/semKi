// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunc(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    if (numberM > 0 && numberN == 0)
    {
        return AkkermanFunc(numberM - 1, 1);
    }
    return AkkermanFunc(numberM - 1, AkkermanFunc(numberM, numberN - 1));
}
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AkkermanFunc(m, n));
