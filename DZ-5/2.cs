/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear();
Console.Write("Введите длинну массива: ");
int a = int.Parse(Console.ReadLine()!);
int[] randomArray = new int[a];
for (int i = 0; i < randomArray.Length; i++)
    {
    randomArray[i] = new Random().Next(0,50);
    Console.Write(randomArray[i] + ", ");
    }
Console.WriteLine();
int sumIndex = 0;
for (int i = 1; i < randomArray.Length; i += 2)
    {
    sumIndex += randomArray[i];
    }
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {sumIndex}");