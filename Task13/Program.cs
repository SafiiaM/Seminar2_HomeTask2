// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


void ThirdNum(int a)
{
if (Math.Abs(a) < 100)
{
    Console.WriteLine(a + " -> Третьей цифры нет");
}
else (Math.Abs(a) > 1000);
{
   a = a / 10;
 }
int n = Math.Abs(a) % 10;
Console.WriteLine(n);
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
ThirdNum(num);


// Console.Write("Введите число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2)
// {
//   Console.WriteLine("третья цифра -> " + anyNumberText[2]);
// }
// else 
// {
//   Console.WriteLine("-> третьей цифры нет");
// }