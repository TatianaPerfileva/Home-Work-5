Console.WriteLine("Задача 34:");

void Zadacha34()
{
    //Задача 34: Задайте массив заполненный случайными положительными 
    //трёхзначными числами. Напишите программу, которая покажет количество 
    //чётных чисел в массиве.
    //[345, 897, 568, 234] -> 2
    int size = 12;
    int [] numbers = new int[size];
    FillArray(numbers, 100, 999);
    PrintArray(numbers);
    FindEvenCount(numbers);

}

void FillArray(int[] nums, int minValue, int maxValue)
{
    maxValue++;
    Random rand = new Random();
    int lenght = nums.Length;
    for (int i = 0; i < lenght; i++)
    {
        nums[i] = rand.Next(minValue, maxValue);
    }
}

void PrintArray(int[] nums)
{
    int lenght = nums.Length;
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < lenght; i++)
    {
        Console.Write(nums[i] + "  ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

void FindEvenCount(int[] nums)
{
    int lenght = nums.Length;
    int count = 0;
    for (int i = 0; i < lenght; i++)
    {
        if (nums[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine("Количество четных чисел в массиве: " + count);
}

Zadacha34();

Console.WriteLine("Задача 36:");

void Zadacha36()
{
    //Задача 36: Задайте одномерный массив, заполненный случайными числами.
    // Найдите сумму элементов с нечётными индексами.
    //[3, 7, 23, 12] -> 19
    //[-4, -6, 89, 6] -> 0

    int size = 8;
    int [] numbers = new int[size];
    FillArray(numbers, -10, 10);
    PrintArray(numbers);
    FindSumNumOddIdx (numbers);
}    

void FindSumNumOddIdx(int[] nums)
{
    int lenght = nums.Length;
    int sum = 0;
    for (int i = 0; i < lenght; i++)
    {
        if (i % 2 > 0)
        {
            sum += nums[i];
        }
    }
    Console.WriteLine("Сумма элементов с нечётными индексами = " + sum);
}

Zadacha36();

Console.WriteLine("Задача 38:");

void Zadacha38()
{
    //Задача 38: Задайте массив вещественных чисел. Найдите разницу 
    //между максимальным и минимальным элементов массива.
    //[3,21 7,04 22,93 -2,71 78,24] -> 80,95
    int size = 5;
    double[] numbers = new double[size];
    FillDoubleArray(numbers);
    PrintDoubleArray(numbers);
    FindDifferensMaxMin(numbers);
    
}

void FillDoubleArray(double[] nums) 
{
    Random rand = new Random();
    int lenght = nums.Length;
    for (int i = 0; i < lenght; i++)
    {
        nums[i] = Math.Round(rand.NextDouble() * 200 - 100, 2);
    }
}

void PrintDoubleArray(double[] nums)
{
    int lenght = nums.Length;
    Console.WriteLine("Вывод массива вещественных чисел:");
    for (int i = 0; i < lenght; i++)
    {
        Console.Write(nums[i] + "  ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

void FindDifferensMaxMin(double[]nums)
{
    int lenght = nums.Length;
    double max = nums[0];
    double min = nums[0];
    for (int i = 0; i < lenght; i++)
    {
        if (nums[i] > max)
        {
            max = nums[i];
        }
        if (nums[i] < min)
        {
            min = nums[i];
        }

    }
    double result = max - min;
    Console.WriteLine("макс = " + max);
    Console.WriteLine("мин = " + min);
    Console.WriteLine("Разница между макс и мин =" + Math.Round(result, 2));
}

Zadacha38();


