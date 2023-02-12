//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

bool Correct(int dayNumber)
{
    if(dayNumber > 0 && dayNumber < 8) return true;
    else 
        {
            return false;
        }
}

Console.WriteLine("В неделе 7 дней. Введи порядковый номер дня недели и узнай, выходной это или нет:");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (Correct(dayNumber))
{
    if (dayNumber > 0 && dayNumber < 6) Console.WriteLine("Нужно еще поработать");
    else Console.WriteLine("Ура, выходной!");
}
else Console.WriteLine("Дня с таким номером нет!");
