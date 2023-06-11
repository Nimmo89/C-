/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,,] array = new int[size[0], size[1], size[2]];
void InputMatrix(int[,,] array)
{
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int  number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(1, 20);
        number = temp[i];
        if (i >= 1)
        {
        for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(1, 50);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
int count = 0; 
for (int x = 0; x < array.GetLength(0); x++)
    {
    for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = temp[count];
                count++;
            }
        }
    }
}
void PrintArra (int[,,] array)
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for(int j = 0; j < array.GetLength(1); j++) 
        { 
            for(int k = 0; k < array.GetLength(2); k++) 
            { 
                Console.Write("[" + i + "," + j + "]" + array[i, j, k] + " "); 
            } 
            Console.WriteLine(); 
        } 
        Console.WriteLine(); 
    } 
    Console.WriteLine(); 
}
InputMatrix(array);
PrintArra(array);