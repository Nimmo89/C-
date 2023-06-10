/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.Clear();
Console.WriteLine("Введите размеры массива: ");
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++) 
    {
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
    }
for (int i = 0; i < array.GetLength(0); i++) 
    {
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
    }
Console.WriteLine("Введите координаты позиции в массиве: ");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if (a>m && b>n)
Console.WriteLine("Такого числа нет");
else
{
    object c = array.GetValue(a,b);
    Console.WriteLine("На этой позиции стоит число: " + c);
}