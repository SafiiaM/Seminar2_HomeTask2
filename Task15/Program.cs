// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void Weekends(int day)
{
    if (day == 6 && day == 7) ;

    {
        Console.WriteLine("Выходной день -> да");
    }
        else if (day < 1 && day > 7)
    {
        Console.WriteLine("Введены некорректные данные");
    }
    else (0 < day <= 5);
    {
        Console.WriteLine("Рабочий день -> нет");

    }
    

}

int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите цифру, обозначающую день недели: ");
Weekends(day);

