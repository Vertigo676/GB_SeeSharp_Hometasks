// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string A = number.ToString();
int sum = 0;
for(int i = 0; i < A.Length; i++)
{
   sum = sum + A[i];
}

Console.WriteLine("Сумма всех элементов числа равна: " + sum);