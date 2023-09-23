// №36 Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.


int ReadData(string msg) //задаем длинну массива
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
int[] CreateArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray(int[] arr)// вывод массива
{
    string arrayString = "[" + string.Join( ",", arr) + "]";
    Console.WriteLine(arrayString);
}
int OddPositionsSum(int[] arr)// находим и суммируем нечетные индексы
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}
void PrintResult(string msg) //результат
{
    Console.WriteLine(msg);
}

int arrayLength = ReadData("Укажите динну массива");
int min = ReadData("укажите нижнюю границу");
int max = ReadData("Укажите верхнюю раницу");
int[] array = CreateArray(arrayLength, min, max);
int odds = OddPositionsSum(array);
PrintArray(array);
PrintResult($"Сумма элентов, имеющих нечетные индексы равна {odds}");
