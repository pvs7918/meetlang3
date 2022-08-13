string PrintXYGradeOfQuater(int quater)
{
    string res;
    switch(quater)
    {
        case 1:
            res = "X > 0, Y > 0";
            break;
        case 2:
            res = "X < 0, Y > 0";
            break;
        case 3:
            res = "X > 0, Y < 0";
            break;
        case 4:
            res = "X < 0, Y < 0";
            break;    
        default:
            res = "Указан неверный номер четверти!";
            break;
    }
    return res;
}

Console.Write("Введите номер четверти: ");
int q = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{PrintXYGradeOfQuater(q)}");