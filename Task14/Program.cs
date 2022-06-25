// Задача 14: Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

void MultiNum(int a)
{
 if (a % 7 == 0 && a % 23 ==0)
 {
    Console.WriteLine(a + " -> " + "кратно одновременно 7 и 23");
 }
 else
 {
    Console.WriteLine(a + " -> " + "не кратно одновременно 7 и 23"); 
 }
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
MultiNum(num);
