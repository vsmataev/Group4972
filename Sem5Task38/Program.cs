// №38 Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементов массива.

double ReadData(string msg) // Задаем длину массива
{
    Console.WriteLine(msg);
    double num = double.Parse(Console.ReadLine() ?? "0");
    return num;
}

double[] CreateArray(int length, double minValue, double maxValue)
{
    double[] array = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        double randomValue = rnd.NextDouble() * (maxValue - minValue) + minValue;
        array[i] = Math.Round(randomValue, 1); // Округляем до десятых (чтоб было красивее)
    }
    return array;
}

void PrintArray(double[] arr) // Вывод массива
{
    string arrayString = "[" + string.Join(", ", arr) + "]";
    Console.WriteLine(arrayString);
}

double BubbleSort(double[] arr) // Сортировка массива пузырьком
{
    int n = arr.Length;
    bool swapped;
    do
    {
        swapped = false;
        for (int i = 1; i < n; i++)
        {
            if (arr[i - 1] > arr[i])
            {
                double temp = arr[i - 1];
                arr[i - 1] = arr[i];
                arr[i] = temp;
                swapped = true;
            }
        }
    } while (swapped);
    double diff = arr[arr.Length - 1] - arr[0]; // Вычисляем разность
    return diff;
}

void PrintResult(string msg) // Результат
{
    Console.WriteLine(msg);
}

double arrayLength = ReadData("Укажите длину массива");
double min = ReadData("Укажите нижнюю границу");
double max = ReadData("Укажите верхнюю границу");
if (min > max)
{
    Console.WriteLine("Ошибка: максимальное значение меньше минимального");
    Environment.Exit(0);
}
else
double[] array = CreateArray((int)arrayLength, min, max);
PrintArray(array);
double difference = BubbleSort(array);
PrintResult($"Разность максимального и минимального значений равна {difference}");
