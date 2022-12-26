// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

int[] FindSumMatrix(int[,] mass)
{
    int[] array = new int[mass.GetLength(0)];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            sum += mass[i, j];
        }
        array[i] = sum;
    }
    return array;
}
int[,] CreateMatrix(int line, int columns)
{
    int[,] matrix = new int[line, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write($"{matrix[i, j],3}");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine(" |");
    }
}
int RowMinSumElements(int[] arr)
{
    int min = arr[0];
    int index = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
            index = i;
        }
    }
    return index;
}
int[,] matrix = CreateMatrix(9, 9);
PrintMatrix(matrix);
int[] array2D = FindSumMatrix(matrix);
Console.WriteLine();
int result = RowMinSumElements(array2D);
Console.WriteLine($"Cтрока с наименьшей суммой элементов -> {result + 1} строка");