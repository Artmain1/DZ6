/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/
int number = ReadInt(" Введи число:");

if(number == 6 || number == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
