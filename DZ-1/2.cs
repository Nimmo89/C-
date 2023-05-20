// Задача 4
/*2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if (max < b) max = b;
if (max < c) max = c;
Console.WriteLine("Максимальное из этих чисел = " + max);