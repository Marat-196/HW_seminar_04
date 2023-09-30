// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Involution(int numA, int numB)
{
    if (numB == 0)
    {
        return 1;
    }
    int value = numA;
    for (int i = 1; i < numB; i++)
    checked
    {
        numA *= value;
    }
    return numA;
}


Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB < 0)
{
    Console.WriteLine("Некорретный ввод!");
    return;
}

int res = Involution(numberA, numberB);

Console.WriteLine($"{numberA}, {numberB} -> {res}");
