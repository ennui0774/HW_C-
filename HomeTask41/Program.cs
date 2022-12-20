// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

int CountPositiveNumbers(int[] numbers)

{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) count++;
    }
    return count;
}
int[] CreateArray(int countElement)
{
    int[] array = new int[countElement];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите элемент под индексом {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i < numbers.Length - 1) Console.Write($"{numbers[i]},");
        else Console.Write($"{numbers[i]}");
    }
}
Console.WriteLine("Введите размер массива");
int number = Convert.ToInt32(Console.ReadLine());
int[] mas = CreateArray(number);
int res = CountPositiveNumbers(mas);
PrintArray(mas);
Console.WriteLine($" -> {res}");
