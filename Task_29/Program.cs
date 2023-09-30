// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] ArrayNumbers(int maxValue, int minValue, int length)
{
    int[] arr = new int [length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}
void PrintArray(int[] array)
{
    string value = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        value = value + $"{array[i]}, ";
    }
    Console.WriteLine($"{value[..^2]} -> [{value[..^2]}]");
}

Console.Write("Введите минимальное значение диапазона: ");
int minNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение диапазона: ");
int maxNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длинну массива: ");
int lenNum = Convert.ToInt32(Console.ReadLine());

int[] arrays = ArrayNumbers(maxNum, minNum, lenNum);

PrintArray(arrays);