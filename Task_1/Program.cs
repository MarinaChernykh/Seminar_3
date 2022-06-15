//Напишите программу, которая принимает на вход
//координаты точки (х и у), причем не= 0, 
//и выдает номер четверти плоскости, в которой
//находится эта точка

void CoordSearch(int x, int y)
{
    if ((x == 0) || (y == 0))
    {
        Console.WriteLine("Параметры некорректны");
    }
    else
    {
        if (x > 0 && y > 0) Console.WriteLine("1 четверть");
        if (x < 0 && y > 0) Console.WriteLine("2 четверть");
        if (x < 0 && y < 0) Console.WriteLine("3 четверть");
        if (x > 0 && y < 0) Console.WriteLine("4 четверть");
    }
}
CoordSearch(5, 7);