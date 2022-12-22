// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Ваше пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string NumbA = Convert.ToString(number);

if( number > 9999 && number < 100000)
{
    if(NumbA[0] == NumbA[4] && NumbA[1] == NumbA[3])
    {
        Console.WriteLine("По вашему запросу стало известно, что введенное вами число ЯВЛЯЕТСЯ палиндромомОМНОМОМНОМНОМ");
    }
    else
    {
        Console.WriteLine("По вашему запросу стало известно, что введенное вам повезет В ДРУГОЙ РАЗ");
    }
}
else
{
    Console.WriteLine("Error 404");
}
