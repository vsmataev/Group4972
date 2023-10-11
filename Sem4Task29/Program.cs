// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// (задание со *) Ввести с клавиатуры длину массива и диапазон значений элементов

Console.Write("Укажите длину массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите минимальное значение элемента: ");
int minValue = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите максимальное значение элемента: ");
int maxValue = int.Parse(Console.ReadLine() ?? "0");

if (minValue > maxValue)
{
    Console.WriteLine("Ошибка: максимальное значение меньше минимального");
    Environment.Exit(0); //говорят, что так лучше чем break
}
else
{
    int[] array = GenerateRandomArray(length, minValue, maxValue);

    Console.WriteLine("Сгенерированный массив:");
    PrintArray(array);
}


static int[] GenerateRandomArray(int length, int minValue, int maxValue)
{
    Random random = new Random();
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }

    return array;
}

static void PrintArray(int[] array)
{
    string arrayString = "[" + string.Join(",", array) + "]"; //тоже люди подсказали
    Console.WriteLine(arrayString);
}