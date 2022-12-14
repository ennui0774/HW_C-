// // Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// // 645 -> 5

// // 78 -> третьей цифры нет

// // 32679 -> 6

int NumberTwo(int num)
{
    while (num > 1000)
    {
        num = num / 10;
    }
    return num % 10;
}
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) Console.WriteLine($"{number} -> Третьей цифры нет");
else
{
    int res = NumberTwo(number);
    Console.Write($"{number} -> {res}");
}