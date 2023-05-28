// Доп задача, сделал как смог найти.
// https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=3&id_topic=35&id_problem=223

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