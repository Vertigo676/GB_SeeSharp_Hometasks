// Задача 55: Задайте двумерный массив.
// Напишите программу, которая заменяте строки на столбцы.

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int [rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}


int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = FillMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();
