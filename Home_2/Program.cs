// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 3D пространстве

void Distance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    Console.WriteLine($"Расстояние = {distance}");
}

Console.Write("Введите координату х точки 1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки 1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки 1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату х точки 2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки 2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки 2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Distance(x1, x2, y1, y2, z1, z2);