// /№34 Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Отсортировать массив методом пузырька

int ReadData(string msg) //задаем длинну массива
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
int[] CreateArray(int length) //создаем массив и заполняем
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] arr)// вывод массива
{
    string arrayString = "[" + string.Join( ",", arr) + "]";
    Console.WriteLine(arrayString);
}
int CountEvenNumbs(int[] arr) //метод для посчета количества четных чисел
{
        int count = 0;
        foreach (int number in arr)
        {
            if (number >= 100 && number <= 999 && number % 2 == 0)
            {
                count++;
            }
        }
        return count;
}
int[] BubbleSort(int[] arr) //сортировка массива пузырьком
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
                    // Обмен элементов
                    int temp = arr[i - 1];
                    arr[i - 1] = arr[i];
                    arr[i] = temp;
                    swapped = true;
                }
            }
        } while (swapped);
        return arr;
    }
void PrintResult(string msg) //результат
{
    Console.WriteLine(msg);
}


int arrayLength = ReadData("Укажите динну массива");
int[] array = CreateArray(arrayLength);
PrintArray(array);
int count = CountEvenNumbs(array);
PrintResult($"Количество четных чисел в массиве равно {count}");
BubbleSort(array);
PrintResult("Сортировка массива пузырьком:");
PrintArray(array);