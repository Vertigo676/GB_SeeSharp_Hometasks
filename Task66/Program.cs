// Задача 66: Задайте значения M и N.
// Напишите программу, 
// которая найдет сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

// void Recursion (int m, int n)
// {
//     if (m > n)
//     {
//         if (n == m)
//         {
//             return;
//         }
//         Recursion(n , m - 1);
//         Console.Write($"{m} ");
//     }
//     else if ( m < n)
//     {
//         if (m == n) return;
//         Recursion(n - 1, m);
//         Console.Write($"{n} ");
//     }
//     else Console.Write($"{m} ");
// }
// Recursion(M, N);

// int SumMN( int m, int n)
// {
//     int res = m;
//     if (m == n)
//     return 0;
//     else
//     {
//         m++;
//         res = m + SumMN(m, n);
//         return res;
//     }
// }

SumFromMtoN(m, n);
void SumFromMtoN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
    int res = m;
    if ( m == n)
    {
        return 0;
    }
    else{
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}
