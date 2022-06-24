// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру 
// этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void SecondNum(int a)
{
    int b = (a / 10) % 10;
    Console.WriteLine(a + " -> " + b);
}
Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100 && num > 999)
{
    Console.WriteLine("Некорректные данные");
}
else
{
  SecondNum(num);
}
