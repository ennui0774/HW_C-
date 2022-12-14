// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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
int NumberOfEvenNumbers(int[] arr)
{
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
if (arr[i] % 2 == 0) count++;
}
return count;
}
int[] array = CreateArrayRndInt(6, 100, 1000);
PrintArray(array);
int countNumber = NumberOfEvenNumbers(array);
Console.WriteLine($" -> {countNumber}");