// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
int[,,] CreateVolumeRndInt(int line, int columns, int depth)
{
    int[,,] array3D = new int[line, columns, depth];
    int r = 1;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = r++;

            }

        }
    }
    return array3D;
}
void Print3D(int[,,] volume)
{
    for (int i = 0; i < volume.GetLength(0); i++)
    {
        for (int j = 0; j < volume.GetLength(1); j++)
        {
            for (int k = 0; k < volume.GetLength(2); k++)
            {
                Console.Write($"{volume[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}
int[,,] volume3D = CreateVolumeRndInt(2, 2, 2);
Print3D(volume3D);