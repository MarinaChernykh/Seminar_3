// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, 
// является ли оно палиндромом

void PalindromCheck(int number)
{
    if (number < -99999 || (number > -10000 && number < 10000) || number > 99999)
    {
        Console.WriteLine("Введенное число не является пятизначным");
    }
    else
    {
        if ((number / 10000 == number % 10) && (number / 1000 % 10 == number / 10 % 10))
        {
            Console.WriteLine("Является полиндромом");
        }
        else Console.WriteLine("НЕ является полиндромом");
    }
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
PalindromCheck(number);
