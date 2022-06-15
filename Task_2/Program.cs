//Напишите программу, которая по заданному номеру
//четверти показывает диапозон возможных координат
//точек этой четверти (х и y)

void CoordSearch(int x)
{
    if ((x < 1) || (x > 4))
    {
        Console.WriteLine("Номер четверти некорректен");
    }
    else
    {
        if (x == 1) Console.WriteLine("x > 0, y > 0");
        if (x == 2) Console.WriteLine("x < 0, y > 0");
        if (x == 3) Console.WriteLine("x < 0, y < 0");
        if (x == 4) Console.WriteLine("x > 0, y < 0");
    }
}
Console.Write("Введите номер четверти:");
int x = Convert.ToInt32(Console.ReadLine());

CoordSearch(x);
