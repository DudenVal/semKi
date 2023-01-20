

void translateToBinary(int number)
{
    if (number == 0) return;
    translateToBinary(number / 2);
    Console.Write(number % 2);
}


Console.Write("Enter numb: ");
int numb = Convert.ToInt32(Console.ReadLine());
translateToBinary(numb);

// 2 Вариант

void ReverseArray(int[] array)
{
int temp = 0;
for(int i = 0; i < array.Length/2; i++)
{
temp = array[i];
array[i] = array[array.Length - 1 - i];
array[array.Length - 1 - i] = temp;
}
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = number;
int length = 0;
while(number > 0)
{
number/=2;
length++;
}

int[] array = new int[length];

for(int i = 0; i < array.Length; i++)
{
array[i] = number2%2;
number2/=2;
}
Console.WriteLine(string.Join(", ", array));
ReverseArray(array);
Console.WriteLine(string.Join(", ", array));