//Задача 6
/*4 -> да
-3 -> нет
7 -> нет*/
Console.Clear();
Console.Write("Введите 1 число: ");
int a = int.Parse(Console.ReadLine()!);
if (a % 2 == 0)
    Console.WriteLine("Число: " + a + " четное");
else
    Console.WriteLine("Число: " + a + " нечетное");