// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}.");
    }
}
double[] Average(int[,] mtrx)
{
    double[] arr = new double[mtrx.GetLength(1)];
    for (int j = 0; j < mtrx.GetLength(1); j++)
    {
        double avg = 0;
        for (int i = 0; i < mtrx.GetLength(0); i++)
        {
            avg += mtrx[i, j];
        }
        arr[j] = Math.Round(avg / mtrx.GetLength(0), 1);
    }
    return arr;
}
int[,] d3 = CreateMatrix(3, 4, 1, 10);
PrintMatrix(d3);
double[] res = Average(d3);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(res);
