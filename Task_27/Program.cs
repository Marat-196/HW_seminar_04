// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumbers(int number)
{
    int count = 0;
    while (number != 0)
    {
        int value = number % 10;
        count += value;
        number /= 10;
    }
    return count;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int res = SumNumbers(num);

Console.WriteLine($"{num} -> {res}");