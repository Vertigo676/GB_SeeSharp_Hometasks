// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(0,10);
        Console.Write(array[i,j] + "|");
    }   
    Console.WriteLine();
}    
Console.WriteLine();   
Console.WriteLine("Теперь введите позиции a и b искомого элемента в данном массиве");
Console.WriteLine("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a <= m & b <= n)
    Console.WriteLine($"На заданной позиции стоит число {array[a,b]}");
if(a > m || b > n)
     Console.WriteLine("Такой позиции в заданном массиве нет");
