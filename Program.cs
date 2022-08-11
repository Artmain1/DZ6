/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/
Console.Write("Введи число:");
int number = Convert.ToInt16(Console.ReadLine());

if(number > 100 && number < 999)
{
    number = (number % 10);
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Третей цифры нету");
}