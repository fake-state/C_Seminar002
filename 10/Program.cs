﻿//  Напишите программу, которая принимает на вход 
//  трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введи трехзначное число и я найду его вторую цифру:");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99 && a < 1000)
{
a = a / 10;
a = a % 10;
Console.WriteLine($"вторая цифра - {a}");
Console.WriteLine("Все получилось. Круто, да?)");
}
else Console.WriteLine("Число не трехзначное!");