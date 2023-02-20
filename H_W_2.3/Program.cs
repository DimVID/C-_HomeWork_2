// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("ведите день недели");
int weekday = Convert.ToInt32 (Console.ReadLine ());
if (weekday == 1)
{
 System.Console.WriteLine("нет"); 
}
if (weekday == 2)
{
 System.Console.WriteLine("нет"); 
}
if (weekday == 3)
{
 System.Console.WriteLine("нет"); 
}
if (weekday == 4)
{
 System.Console.WriteLine("нет"); 
}
if (weekday == 5)
{
 System.Console.WriteLine("нет"); 
}
if (weekday == 6)
{
 System.Console.WriteLine("да");
}
if (weekday == 7)
{
 System.Console.WriteLine("да"); 
}
if (weekday < 1 || weekday > 7 )
{
    System.Console.WriteLine("такого дня нет");
}