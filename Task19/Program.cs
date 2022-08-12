// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите число: ");
string num = Console.ReadLine();

void a(string num)
{
    if(num[0] == num[4] || num[1] == num[3])
    {
        Console.WriteLine($"Это число: {num} - Палиндром.");
    }
    else Console.WriteLine($"Это число: {num} - Не палиндром.");
}

if(num!.Length == 5)
{
    a(num);
}

else Console.WriteLine($"Подсказка: Введите пятизначное число");