//Задача 15
/* 6 -> да
7 -> да
1 -> нет */
Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
string b = "А если нормально подумать?";
string check(int a)
{
if (a >= 6 && a < 8) b = "Да";
if (a >= 1 && a < 7) b = "Нет";
return b;
}
System.Console.WriteLine(check(a));