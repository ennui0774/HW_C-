// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool Weekend(int num)
{

    return num == 6 || num == 7;

}
Console.WriteLine("Введите день недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 8 && number > 0)
{
    bool res = Weekend(number);
    Console.Write(res ? $"{number} -> Да" : $"{number} -> Нет");
}
else Console.WriteLine($"{number} -> Такого дня недели нет");

