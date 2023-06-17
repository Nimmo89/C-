/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Clear();
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);
int ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return ackermann(m - 1, 1);
    else
        return ackermann(m - 1, ackermann(m, n - 1));
}
Console.WriteLine("Ackermann({0}, {1}) = {2}", m, n, ackermann(m, n));