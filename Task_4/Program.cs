// Напишите программу, которая принимает на вход
// число N и выдает таблицу квадратов чисел от 1 до N.


void Multi(int N)
{
    for (int i = 1; i <= N; i++)
    {
        //int res = i*i;
        Console.Write($"{i * i} ");
    }
}

Console.Write("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

Multi(N);
