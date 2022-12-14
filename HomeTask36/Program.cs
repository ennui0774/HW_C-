// Задача 36: Задайте одномерный массив,
// заполненный случайными числами. Найдите
// сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int siz, int min, int max)
{
int[] array = new int[siz];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
int num = rnd.Next(min, max - 1);
array[i] = num;
}
return array;
}
void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
if (i < array.Length - 1) Console.Write($"{array[i]}, ");
else Console.Write($"{array[i]}");
}
Console.Write("]");
}
int SumElementsOfOdd(int[] arr)
{
int sum = 0;
for (int i = 1; i < arr.Length; i += 2)
{
sum += arr[i];
}
return sum;
}
int[] randomArray = CreateArrayRndInt(6, -50, 50);
PrintArray(randomArray);
int sumOdd = SumElementsOfOdd(randomArray);
Console.WriteLine($" - > {sumOdd}");
