// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели: ");
int weekday = Convert.ToInt32(Console.ReadLine());

if(weekday == 1) {
    Console.Write("Понедельник на дворе! ");}
else if (weekday == 2) {
    Console.Write("Вторник на дворе! ");}
else if (weekday == 3) {
    Console.Write("Среда на дворе! ");}
else if (weekday == 4) {
    Console.Write("Четверг на дворе! ");}
else if (weekday == 5) {
    Console.Write("Пятница на дворе! ");}
else if (weekday == 6) {
    Console.Write("Суббота, субботка, субботонька! ");}
else if (weekday == 7) {
    Console.Write("Урашечки-ура! Воскресенье! ");}
else if (weekday >= 8)
{
Console.WriteLine("А вот и не угадал. В неделе ж всего 7 дней =) ");
}
if(weekday <= 5) {
    Console.WriteLine("Иди работать, собака!");
}
if(weekday == 6 || weekday == 7) {
    Console.WriteLine("Расслабься, это выходной!");
}
