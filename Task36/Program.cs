﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях(индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] FillArray(int size)
// {
//     int[] arr = new int[size];
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 99999);
//     }
//     return arr;
// }

// Console.Write("введите число: ");
int [] array = new int [11];
for(int i = 1; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 99);
}

Console.WriteLine(string.Join(",", array));
int sum = 0;
for (int i = 1; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
}
Console.Write(sum);