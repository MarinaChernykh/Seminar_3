// Напишите программу, которая принимает на
// вход число N и выдает таблицу кубов чисел
// от 1 до N.

void Cubes(int N)
{
    if (N < 1) Console.WriteLine("Введенное число меньше 1");
    else
    {
        for (int i = 1; i <= N; i++)
        {
            int res = i * i * i;
            Console.Write($"{res} ");
        }
    }
}

Console.Write("Введите значение числа N: ");
int N = Convert.ToInt32(Console.ReadLine());
Cubes(N);
