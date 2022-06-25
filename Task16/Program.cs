// Задача 16: Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

void Square(int a, int b)
{
    if (a == b * b)
    {
        Console.WriteLine(a + "," + b + " -> является");
    }
    else
    {
        if (b == a * a)
        {
            Console.WriteLine(a + "," + b + " -> является");
        }
        else
        {
            Console.WriteLine(a + "," + b + " -> не является");
        }
    }
}
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Square(number1, number2);
