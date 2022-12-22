// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1,7 -> такого элемента в массиве нет

int[,] CreateMatrix(int rows, int colums, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j],4} |");
        }
        Console.WriteLine();
    }
}
int FindElement(int rows, int colums, int[,] mtrx)
{
    return mtrx[rows - 1, colums - 1];
}
int[,] array2d = CreateMatrix(5, 5, -10, 10);
PrintMatrix(array2d);
Console.WriteLine("Введите строку:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец:");
int n = Convert.ToInt32(Console.ReadLine());
if (m > array2d.GetLength(0) || n > array2d.GetLength(1) || m < 1 || n < 1) Console.WriteLine($"{m},{n} -> Такого элемента в массиве нет");
else
{
    int result = FindElement(m, n, array2d);
    Console.WriteLine($"{m},{n} -> {result}");
}
