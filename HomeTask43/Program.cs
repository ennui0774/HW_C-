// Задача 43: Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// k1*x+b1=k2*x+b2
// k1*x-(k2*x)=b2-b1
// x(k1-k2)=b2-b1
// x=(b2-b1)/(k1-k2)
double CalcX(double bx1, double kx1, double bx2, double kx2)
{
return (bx2 - bx1) / (kx1 - kx2);
}
double CalcY(double x, double bx1, double kx1, double bx2, double kx2)
{
return kx1 * x + bx1;
}
Console.WriteLine("ЗАДАНЫ ДВЕ ПРЯМЫЕ 'y = k1 * x + b1' и 'y = k2 * x + b2'");
Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
if (k1 != k2)
{
double x = Math.Round(CalcX(b1, k1, b2, k2), 1, MidpointRounding.ToZero);
double y = Math.Round(CalcY(x, b1, k1, b2, k2), 1, MidpointRounding.ToZero);
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x};{y})");
}
else Console.WriteLine("Прямые параллельны");