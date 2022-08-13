/*
Домашняя работа
Задача 19.
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом (читаются одинаково как справа налево, так и слева направо).
14212 -> нет
12821 -> да
23432 -> да
*/

bool IsItPalindrome(int numb)
{
// параметр numb - пятизназное число
    bool res;
    int i;
    int len;
    int []dig = new int[5]; //массив из пяти элементов
    
    len=dig.Length;
    //разбиваем число на массив цифр
    for(i=len-1;i>=0;i--)
    {
        dig[i]=numb%10;
        numb/=10;
    }

    res=true;
    for(i=0;i < len/2;i++)
    {
        if(dig[i]!=dig[len-i-1])
        {
            res=false;
            break;
        }
    }
    return res;
}

Console.Write("Введите пятизначное число: ");
int numb = int.Parse(Console.ReadLine()!);

Console.Write($"Является ли палиндромом число: {numb} -> ");
if(IsItPalindrome(numb))
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}