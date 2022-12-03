// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double[size];

FillArrayRandomNumbers(numbers);

Console.WriteLine("Массив: ");

PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int x = 0; x < numbers.Length; x++)
{
    if (numbers[x] > max)
    {
        max = numbers[x];
    }
    if (numbers[x] < min)
    {
        min = numbers[x];
    }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное = {max}, минимальное = {min}");
Console.WriteLine($"Разница между максимальным и минимальным = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}