//Задача 8
/*5 -> 2, 4
8 -> 2, 4, 6, 8*/
Console.Clear();
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);
for(int i=1;i<=n;i++)
    {
    if (i % 2 == 0)
    Console.Write(i + ", ");
    }