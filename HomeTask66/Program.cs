// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumInterval1(int num1, int num2)
{
    if (num1 >= num2) return num1 + SumInterval1(num1 - 1, num2);
    else return 0;

}
int SumInterval2(int num1, int num2)
{
    if (num1 <= num2) return num1 + SumInterval2(num1 + 1, num2);
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