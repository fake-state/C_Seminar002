//Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

int ThirdNumber (int a)
{
    while (a > 999)
    {
        a = a / 10;
    }
    return a % 10;
}

Console.WriteLine("Введи трехзначное число и я найду его последнюю цифру:");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 100) Console.WriteLine("Третей цифры тут нет!");
else
Console.WriteLine(ThirdNumber(a));