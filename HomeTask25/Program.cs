// Задача 25: Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16

Console.WriteLine("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В (натуральное):");
int b = Convert.ToInt32(Console.ReadLine());

int Degree(int num1, int num2)
{
int count = 1;
int result = 1;
while (count <= num2)
{
result = result * num1;
count++;
}
return result;
}
if (b < 0) Console.WriteLine("Число В не является натуральным");
else Console.WriteLine($"{a}, {b} -> {Degree(a, b)}");