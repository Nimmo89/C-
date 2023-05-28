// Задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*int a = 5; 
int b = 7;
int a1 = 2;
int b1 = 10;
int a2 = -9;
int b2 = -3;*/
Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
    Console.WriteLine(a);
else
    Console.WriteLine(b);