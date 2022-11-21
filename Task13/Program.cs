// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

string str = number.ToString();
// Console.WriteLine(str);
while(number >= 100)
{
    Console.WriteLine(str[2]);
    break;
}
while(number <= -100)
{
    Console.WriteLine(str[3]);
    break;
}
if(number <= 99 || number >= -99)
{
    Console.WriteLine("Третьей цифры нет");
}