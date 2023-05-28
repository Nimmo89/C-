//Задача 13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/* 645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int b(int a)
    {
        while (a > 999)
            {
                a /= 10;
            }
        return a % 10;
    }
bool check(int a)
    {
        if (a < 100)
        return false;
        else return true;
    }
if (check(a) != true)
System.Console.WriteLine("Третьей цифры нет");
else
System.Console.WriteLine(b(a));