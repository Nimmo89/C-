//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/* A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Clear();
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int x1 = ReadInt ("Введите координату X точки A: ");
int y1 = ReadInt ("Введите координату Y точки A: ");
int z1 = ReadInt ("Введите координату Z точки A: ");
int x2 = ReadInt ("Введите координату X точки B: ");
int y2 = ReadInt ("Введите координату Y точки B: ");
int z2 = ReadInt ("Введите координату Z точки B: ");

int deltaX = x2 - x1;
int deltaY = y2 - y1;
int deltaZ = z2 - z1;

double dis = Math.Sqrt(deltaX*deltaX+deltaY*deltaY+deltaZ*deltaZ);
Console.WriteLine($"Длинна отрезка {dis}");