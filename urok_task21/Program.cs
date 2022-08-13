﻿/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

Console.Write("x1:");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("y1:");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write("x2:");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write("y2:");
double y2 = double.Parse(Console.ReadLine()!);

double dist;
double dx;
double dy;

dx=Math.Abs(x1-x2);
dy=Math.Abs(y1-y2);
dist = Math.Sqrt(Math.Pow(dx,2)+Math.Pow(dy,2));

Console.Write($"Расстояние равно: {dist}");