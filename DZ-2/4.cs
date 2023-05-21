//Доп задача, сделал как смог найти.

Console.Clear();
int N, maxStart = 0, maxTwo = 0;
while (true)
{
    Console.WriteLine("Введите число: ");
    N = int.Parse(Console.ReadLine()!);
    
    if (N > maxStart)
    {
        maxTwo = maxStart;
        maxStart = N;
    }
    else if (N > maxTwo)
    {
        maxTwo = N;
    }
Console.WriteLine("Второе максимальное число: " + maxTwo);
}