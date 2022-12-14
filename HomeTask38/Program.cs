// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и
// минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] CreateArrayRndInt(int siz, int min, int max)
{
double[] array = new double[siz];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
double composition;
int num1 = rnd.Next(min, max);
double num2 = rnd.NextDouble();
if (num1 < 0) composition = num1 - num2;
else composition = num1 + num2;
array[i] = Math.Round(composition, 1);
}
return array;
}
void PrintArray(double[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
if (i < array.Length - 1) Console.Write($"{array[i]} | ");
else Console.Write($"{array[i]}");
}
Console.Write("]");
}
double MaxElements(double[] arr)
{
double max = arr[0];
for (int i = 0; i < arr.Length; i++)
{
if (arr[i] > max) max = arr[i];
}
return max;
}
double MinElements(double[] arr)
{
double min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
if (arr[i] < min) min = arr[i];
}
return min;
}
double[] array = CreateArrayRndInt(6, -100, 100);
PrintArray(array);
double maxElement = MaxElements(array);
double minElement = MinElements(array);
double result = Math.Round(maxElement - minElement, 1);
if (result * 10 % 10 == 0) Console.WriteLine($" -> {result},0");
else Console.WriteLine($" -> {result}");
