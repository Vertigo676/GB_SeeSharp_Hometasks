// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
int sum = 0;
for(int i = 0; i < array.Length; i++)
{
   sum = sum + array[i];
}

Console.WriteLine(sum);