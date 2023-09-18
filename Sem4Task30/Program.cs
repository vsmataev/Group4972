// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.

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
    for(int i=0; i<length; i++)
    {
        array[i] = rnd.Next(0,2); //генерируется либо 0 либо 1
    }
    return array;
}

void PrintArray(int[] array) //выводим массив
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    Console.Write(array[i] + ",");
    Console.Write(array[array.Length - 1] + "]");
    
}

int length = ReadData("размер массива");
int[] array = CreateArray(length);
PrintArray(array);