// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).


// Console.WriteLine("Введите номер четверти: ");
// int N = Convert.ToInt32(Console.ReadLine());


// if(N == 1)
// {
//     Console.WriteLine("X > 0, Y > 0");
// }
// else if(N == 2)
// {
//     Console.WriteLine("X < 0, Y > 0");
// }
// else if(N == 3)
// {
//     Console.WriteLine("X < 0, Y < 0");
// }
// else if(N == 4)
// {
//     Console.WriteLine("X > 0, Y < 0");
// }
// else 
// {
//     Console.WriteLine("Ошибка");
// }

// ------------------Другое решение----------------


string[] Array = {"X > 0, Y > 0",
                  "X < 0, Y > 0",
                  "X < 0, Y < 0",
                  "X > 0, Y < 0"};

Console.WriteLine("Введите номер четверти: ");
int Numbers = Convert.ToInt32(Console.ReadLine());
if(Numbers >= 1 && Numbers <= 4)
{
    Console.WriteLine(Array[Numbers - 1]);
}
else
{
    Console.WriteLine("Неверный ввод" );
}
