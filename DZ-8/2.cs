/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

/* Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] arr = new int[size[0], size[1]];
void InputMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(1, 9);
    }
}
void PrintArra (int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"{arr[i,j]}\t");
    }
    Console.WriteLine();
  }
}
InputMatrix(arr);
PrintArra(arr);
int SumLine(int[,] array, int i)
{
    int sum = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    }
    return sum;
}
int minSum = 1;
int sum = SumLine(arr, 0);
    for (int i = 1; i < arr.GetLength(0); i++)
{
    if (sum > SumLine(arr, i))
    {
        sum = SumLine(arr, i);
        minSum = i+1;
    }
}
Console.WriteLine($"\n{minSum} - строкa с наименьшей суммой элементов "); */