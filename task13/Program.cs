// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите чило: ");
string num = Console.ReadLine();
if(num.Length > 2)
{
    char threeChar = num[2];
    Console.WriteLine(threeChar);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}