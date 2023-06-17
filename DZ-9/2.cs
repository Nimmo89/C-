/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);
int sum = 0;
for (int i = m; i <= n; i++)
{
    sum += i; // добавляем каждый элемент к сумме
}
Console.WriteLine($"Сумма чисел от {m} до {n} равна: {sum}");