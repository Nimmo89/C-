/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

Console.Clear();
Console.Write("Введите длинну массива: ");
int a = int.Parse(Console.ReadLine()!);
double[] randomArray = new double[a];
int end = 50, begin = 1;
for (int i = 0; i < randomArray.Length; i++)
    {
    randomArray[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2);
    Console.Write(randomArray[i] + ", ");
    }
double min = randomArray[0];
double max = randomArray[0];
int b = 1;
while (b < randomArray.Length)
    {
    if (max<randomArray[b])
        max = randomArray[b];
    if (min>randomArray[b])
        min = randomArray[b];
    b = b + 1;
    }
Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");