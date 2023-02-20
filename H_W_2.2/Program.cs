// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int userNumber = Prompt("\nВведите 3-х значное число и больше");
if (Validation(userNumber)) System.Console.WriteLine($"\nТретья цифра числа {userNumber} > {ShowThreeDigitalNumber(userNumber)} ");
else System.Console.WriteLine("\nТретьей цифры нет "); 

int Prompt(string msg)
{
    System.Console.WriteLine($"{msg} > ");
    return Convert.ToInt32(Console.ReadLine());
}

bool Validation(int num)
{
    if (num > 99) return true;
    return false;
}
int ShowThreeDigitalNumber(int number)
{
    while (number >999)
    {
        number = number / 10;
    }
    return number % 10;
}