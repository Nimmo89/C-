﻿//Задача 10
/* 456 -> 5
782 -> 8
918 -> 1 */
Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
if (a >= 100 && a < 1000)
    {
    int mid = (a % 100 - a % 10) / 10;
    Console.WriteLine(mid);
    }
else
    Console.WriteLine("Это число не трехзначное");