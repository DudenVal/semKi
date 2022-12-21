// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter you number: ");
int numb = Convert.ToInt32(Console.ReadLine());

    if(numb > 100 && numb < 1000)
    {
        int digit1 = numb % 10;
        Console.WriteLine(digit1);
    }

    else if (numb > 1000)
    {
        int digit2 = numb % 1000;
        int digit3 = digit2 / 100;
        Console.WriteLine(digit3);
    }
    else if (numb < 100)
    {
        Console.WriteLine("There is no third digit in your number " + numb);
    }
    
/// Алексей, я пытался сделать через while, но что-то не пошло и я сделал грубо(только то, что у меня просили).
/// Этот код действует до 100 000. Был бы очень счастлив, если бы вы обьяснили, как сделать это через string и while)


