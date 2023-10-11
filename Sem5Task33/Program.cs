// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int[] GenArray(int num, int lowBorder, int highBorder)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
//поиск числа и его индекса (добавил дополнительно)
(bool found, int index) FindNumberInArray(int[] arr, int targetNumber) 
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == targetNumber)
        {
            return (true, i); // Если число найдено, возвращаем true и индекс
        }
    }
    return (false, -1); // Если число не найдено, возвращаем false и -1
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int[] array = GenArray(6, 3, 10); //задаем паремерты массива (размер, нижняя граница, верхняя граница)
PrintArray(array);
int number = ReadData("Введите число для проверки");
(bool found, int index) result = FindNumberInArray(array, number);

if (result.found)
{
    PrintResult($"Число {number} найдено в массиве - индекс {result.index}.");
}
else
{
    PrintResult($"Число {number} не найдено в массиве.");
}