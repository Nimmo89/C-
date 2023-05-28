// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/* 3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Таблица кубов:\n");
for (int i=1; i<=n; i++)
    {
    int k = i*i*i;
    Console.Write($"{k}, ");
    }