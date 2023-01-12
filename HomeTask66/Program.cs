
 // Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumInterval1(int m, int n)
{
    if (m >= n) return m + SumInterval1(m - 1, n);
    else return 0;

}
int SumInterval2(int m, int n)
{
    if (m <= n) return n + SumInterval2(m, n - 1);
    else return 0;

}
Console.WriteLine("Введите натуральное число (M): ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число (N): ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (number1 > number2) result = SumInterval1(number1, number2);
else result = SumInterval2(number1, number2);
Console.WriteLine(result);
