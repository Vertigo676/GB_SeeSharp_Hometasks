// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
int [,] matrixFirst = FillMatrix(m,n);
PrintMatrix(matrixFirst);
Console.WriteLine();

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int [,] matrixSecond = FillMatrix(m,n);
PrintMatrix(matrixSecond);
Console.WriteLine();

int[,] resultMatrix = new int [matrixFirst.GetLength(0), matrixSecond.GetLength(1)];
for ( int i = 0; i < matrixFirst.GetLength(0); i++)
{
    for( int j = 0; j < matrixSecond.GetLength(1); j++)
    {
        int sum = 0;
        for ( int k = 0; k < matrixFirst.GetLength(1); k++)
        {
            sum += (matrixFirst[i,k] * matrixSecond[k,j]);
        }
        resultMatrix[i,j] = sum;
    }
}
PrintMatrix(resultMatrix);