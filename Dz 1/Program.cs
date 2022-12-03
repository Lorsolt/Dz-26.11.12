// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.WriteLine("Размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] num = new int[size];

ArrayRandomNumbers(num);

Console.WriteLine("Массив: ");

PrintArray(num);
int count = 0;

for (int c = 0; c < num.Length; c++)
    if (num[c] % 2 == 0)
        count++;

Console.WriteLine($"Чисел {num.Length} , {count} чётных");

void ArrayRandomNumbers(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100, 999);
    }
}
void PrintArray(int[] num)
{
    Console.Write("[ ");
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}