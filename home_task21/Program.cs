/*
Домашняя работа
Задача 21.
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double FindDist3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double res;
    double dx;
    double dy;
    double dz;
    

    dx=Math.Abs(x1-x2);
    dy=Math.Abs(y1-y2);
    dz=Math.Abs(z1-z2);

    res = Math.Sqrt(Math.Pow(dx,2)+Math.Pow(dy,2)+Math.Pow(dz,2));
    return res;
}

Console.Write("A(x):");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("A(y):");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write("A(z):");
double z1 = double.Parse(Console.ReadLine()!);
Console.Write("B(x):");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write("B(y):");
double y2 = double.Parse(Console.ReadLine()!);
Console.Write("B(z):");
double z2 = double.Parse(Console.ReadLine()!);

// {имя_переменной:f2}   - вывод с 2-я знаками после запятой
Console.Write($"Расстояние равно: {FindDist3D(x1, y1, z1, x2, y2, z2):f2}");