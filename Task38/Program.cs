// Задача 38: Задайте массив вещественных(тип double) чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] array = new double [7];
Random rnd = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
    array[i] = Math.Round(array[i], 2);
}

Console.Write(string.Join(" | ", array));

double max = array[0];
double min = array[0];
for(int i = 0; i < array.Length; i++)
{
    if(max < array[i])
    {
        max = array[i];
    }
    if(min > array[i])
    {
        min = array[i];
    }
}
double result = Math.Round((max - min), 2);
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("Наибольше число показанного массива равно " + max);
Console.WriteLine(" ");
Console.WriteLine("Наименьшее число показанного масиива равно " + min);
Console.WriteLine(" ");
Console.WriteLine("Разница между наибольшим и наименьшим числами равна " + result);