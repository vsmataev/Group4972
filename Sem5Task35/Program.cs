// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99]. 

int[] GenArray(int num, int lowBorder, int highBorder)
{

    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder + 1);
    }
    return array;
}

// Печатаем результат
void PrintArray(int[] arr)
{
    {
    string arrayString = "[" + string.Join( ",", arr) + "]"; //выводим массив красиво
    Console.WriteLine(arrayString);
    }
}

// Находим количество элементов в заданном диапазоне
int ElementCount(int[] arr, int x, int y)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= x && arr[i] <= y)
        {
            count++;
        }
    }
    return count;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Вызываем генерацию массива, выводим изначальный массив, инвертируем массив и выводим инвертированный массив
int[] array = GenArray(123, 0, 1000);
PrintArray(array);
// добавить возможность ручного вводв значений?
int x = 10;
int y = 99;
int count = ElementCount(array, x, y);
PrintResult($"{count} элементов в заданном диапазоне");