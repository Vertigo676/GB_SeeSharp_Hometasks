// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int [] array = new int [10];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-15, 15);
}
 Console.WriteLine(string.Join(" , ", array));
 int count = 0;
 for( int i = 0; i < array.Length; i++)
 {
    if(array[i] > 0)
    count = count + 1;
 }
 Console.Write(count);