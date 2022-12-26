// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Матрицу P можно умножить на матрицу K только в том случае, 
// если число столбцов матрицы P равняется числу строк матрицы K. 
// Матрицы, для которых данное условие не выполняется, умножать нельзя.

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
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write($"{matrix[i, j],3}");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine(" |");
    }
}
int[,] MatrixMultiplication(int[,] mtrx1, int[,] mtrx2)
{
    int[,] matrix = new int[mtrx1.GetLength(0), mtrx2.GetLength(1)];
    for (int i = 0; i < mtrx1.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx2.GetLength(1); j++)
        {
            matrix[i, j] = 0;
            for (int k = 0; k < mtrx2.GetLength(0); k++)
            {
                matrix[i, j] += mtrx1[i, k] * mtrx2[k, j];
            }
        }
    }
    return matrix;
}
Console.WriteLine("Введите количество строк первой матрицы: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы: ");
int col1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк второй матрицы: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int col2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = CreateMatrix(row1, col1);
int[,] matrix2 = CreateMatrix(row2, col2);
PrintMatrix(matrix1);
Console.WriteLine("    X");
PrintMatrix(matrix2);
if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    int[,] result = MatrixMultiplication(matrix1, matrix2);
    Console.WriteLine("    =");
    PrintMatrix(result);
}
else
{
    Console.WriteLine("Число столбцов первой матрицы не равняется числу строк второй матрицы.");
    Console.WriteLine("Умножать такие матрицы нельзя!");
}