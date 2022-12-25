﻿// Задача 57
// Составить частотный словарь элементов двумерного масиива.
// Частотный словарь содержи инфомраци. о том,
// сколько раз встречается элемент входных данных

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

for(int k = 0; k < 10; k++)
{
    int count = 0;
    for( int i = 0; i < matrix.GetLength(0); i++)
    {
        for( int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] == k)
            {
                count++;
            }
        }
    }
    if(count != 0) Console.WriteLine($"Кол-во повторений для {k} = {count}");
}