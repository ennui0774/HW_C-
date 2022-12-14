// // Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа. Выполнить с 
// помощью числовых операций (целочисленное деление, остаток от деления).

// // 456 -> 5
// // 782 -> 8
// // 918 -> 1


int NumberTwo(int num)
{
    num = num / 10;
    num = num % 10;
    return num;
}
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int resault = NumberTwo(number);
    Console.WriteLine(resault);

}
else Console.WriteLine("Число не является трехзначным");