// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = CreateMatrix(m, n, -10, 10);
PrintArray(matrix);
double[,] CreateMatrix(int rows, int colums, int min, int max)
{
    Random rnd = new Random();
    double[,] matrix = new double[rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
        }
    }
    return matrix;
}
void PrintArray(double[,] numbers)
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