// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine($"Ваше счастливое число - {number}");

int digit1 = number/10;
int digit2 = digit1%10;

Console.WriteLine($"И вторая цифра Вашего счастливого числа от 100 до 1000 это {digit2}");
