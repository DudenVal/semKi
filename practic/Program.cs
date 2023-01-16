// Дано трехзначное число. Определить: кратна ли пяти сумма его цифр.

Console.WriteLine("Enter your number: ");

string numb = Convert.ToString(a);
int i = 0;
int sum = numb[0] + numb[1] + numb[2];
if (sum == 5)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}