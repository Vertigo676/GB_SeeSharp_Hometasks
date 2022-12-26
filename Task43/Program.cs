// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Число b1 равно: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Число k1 равно: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Число b2 равно: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Число k2 равно: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if(k1 == k2)
{
    Console.WriteLine("Параллельные прямые не пересекаются");
}
else
{
    double Ax = Math.Round((b2 - b1)/(k1 - k2), 2);
    double Ay = Math.Round((k1 * (b2 - b1)/(k1 - k2) + b1), 2);
    Console.WriteLine($"({Ax}); ({Ay})");
}
