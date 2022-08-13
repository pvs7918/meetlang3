/*
Домашняя работа
Задача 23.
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

string GetCubeTable(int N)
{
// параметр numb - пятизназное число
    string res="";
    int i;
    
    for(i=1;i<=N;i++)
    {
        if (i==1)
            res+=$"{Math.Pow(i,3)}"; //перед первым элементом запятую не ставим
        else
            res+=$", {Math.Pow(i,3)}";
    }

    return res;
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Таблица кубов числа: {N}");
Console.WriteLine($"{N} -> {GetCubeTable(N)}");