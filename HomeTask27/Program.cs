// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit(int num)
{
int num_refresh = num;
int count = 0;
while (num != 0)
{
num = num / 10;
count++;
}
int digit = 0;
while (count > 0)
{
digit = digit + (num_refresh % 10);
num_refresh = num_refresh / 10;
count--;
}
return Math.Abs(digit);
}

Console.WriteLine($"{number} -> {SumDigit(number)}");