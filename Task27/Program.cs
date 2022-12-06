// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; number > 0; i++)
{
   sum = sum + number%10;
   number = number/10;
}
Console.Write(sum);
