// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());


void Weekends (int day) 
{
  if (day == 6 || day == 7) 
  {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (day < 1 || day > 7) 
  {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

Weekends(day);
