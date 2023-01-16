// Задача 26: Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.WriteLine("Enter you number: ");
int numb = Convert.ToInt32(Console.ReadLine());
string a = Convert.ToString(numb);

for (int i = 0; i < a.Length; i++)
{

}
Console.WriteLine("Количество чисел = " + a.Length);

// ------------------------or--------------------
string a = Console.ReadLine();
if (int.TryParse(a, out int A))
{
    Console.WriteLine(a.Length);
}
else
{
    Console.WriteLine("Ошибка");
}

