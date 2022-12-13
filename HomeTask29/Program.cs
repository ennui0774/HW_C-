// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void PrintArray(int[] array)
{
int count = array.Length;
for (int i = 0; i < count; i++)
{
if (i < count - 1) Console.Write($"{array[i]}, ");
else Console.Write(array[i]);
}
}
void FillArray(int[] arr, int a, int b)
{

for (int i = 0; i < arr.Length; i++)
{
arr[i] = new Random().Next(a, b);
}
}
Console.WriteLine("Введите кол-во элементов массива: ");
int count = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] myArray = new int[count];
Console.WriteLine($"Введите диапазон для значений массива: ");
Console.Write($"От:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"До:");
int num2 = Convert.ToInt32(Console.ReadLine());
bool IsTrue = true;
while (IsTrue)
{
if (num2 > num1)
{
FillArray(myArray, num1, num2);
PrintArray(myArray);
Console.Write(" -> ");
Console.Write("[");
PrintArray(myArray);
Console.Write("]");
IsTrue = false;
}
else
{
Console.WriteLine("Неверный диапазон, 'От' должно быть меньше чем 'До'");
Console.WriteLine("Введите диапазон еще раз ");
Console.Write($"От:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"До:");
num2 = Convert.ToInt32(Console.ReadLine());
}
}