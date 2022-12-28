// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа от N до 1.
// Выполнить с помощью рекурсии.

int count = 0;
void Numbers (int num)
{
    if (num == 0)
    {
        return;
    }
     Console.Write($"{num} ");
     Numbers(num - 1);
     
}
Console.Write("Введите число: ");
int nums = int.Parse(Console.ReadLine());
Numbers(nums);