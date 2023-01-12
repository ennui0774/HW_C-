// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных 
// числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int nN, int mM)
{
    if (nN == 0) return mM + 1;
    else if (mM == 0) return Akkerman(nN - 1, 1);
    return Akkerman(nN - 1, Akkerman(nN, mM - 1));
}
Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
<<<<<<< HEAD
int result = Akkerman(m, n);
Console.Write($"m = {m}, n = {n} -> A({m},{n}) = {result}");
=======
if (m < 4 && n < 12 && m >= 0 && n >= 0)
{
    int result = Akkerman(m, n);
    Console.Write($"m = {m}, n = {n} -> A({m},{n}) = {result}");
}
>>>>>>> df1bd024adbd41b6ef60ecbafa4e9a28bd30725c
