// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int GetSumNumb(int num)
{
    int sum = 0;
    int abs = 0;
    while (num > 0)
    {
        abs = num % 10;
        sum = sum + abs;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine($"Сумма цифр в числе = {GetSumNumb(num)}");