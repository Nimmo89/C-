/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Clear();
Console.Write("Введите длинну массива: ");
int a = int.Parse(Console.ReadLine()!);
int[] randomArray = new int[a];
for (int i = 0; i < randomArray.Length; i++)
    {
    randomArray[i] = new Random().Next(99,1000);
    Console.Write(randomArray[i] + ", ");
    }
Console.WriteLine();
int count = 0;
for (int i = 0; i < randomArray.Length; i++)
    {
    if (randomArray[i] % 2 == 0)
        count++;
    }   
Console.WriteLine($"Количество чётных чисел в массиве -> {count} ");