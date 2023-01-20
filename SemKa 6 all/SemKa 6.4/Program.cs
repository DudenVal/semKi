// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

Console.WriteLine("This is task 38. Enter the size of array: ");
int Size45 = Convert.ToInt32(Console.ReadLine());
int[] array45 = new int[Size45];
int[] Copyarray = new int[Size45];


FillArray(array45);

for(int i = 0; i < Copyarray.Length; i++)
{
    Copyarray[i] = array45[i];
}
Console.WriteLine("ваш скопипастинный массив:");
Console.WriteLine('[' + string.Join(',', Copyarray) + ']');