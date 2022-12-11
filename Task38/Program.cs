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

 double minValue = array[0];
 double maxValue = array [0];
 double result = maxValue - minValue;
 for( int i = 1; i < array.Length; i++)
 { 
     for( int j = 1; j < array.Length; j++)
     {
     if(array[0] < array[i])
         {
             minValue = array[i];
         }
     if(array[0] > array[j])
         {
              maxValue = array[j];
         }
    }
 }
 Console.Write(result);