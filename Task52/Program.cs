// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
int sum = 0;

int count = 0;

for(int j = 0; j < n; j++) 
{
    for(int i = 0; i < m; i++)
    {
     sum = sum + array[i,j];
     count++;
    }
    Console.WriteLine("Количество элементов в данном столбце равно " + count);
    Console.WriteLine("Сумма всех элементов в столбце равна " + sum); 
    break;
   
}
double mid = sum/count;
Console.WriteLine("Среднее арифметическое всех чисел в столбце равно " + mid);