// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Создание и заполнение двумерного массива (по сути - таблица)
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    Random rnd = new Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rnd.Next(downBorder, topBorder + 1);
        }
    }
    return array2D;
}
void Print2DArray(int[,] matrix, string message)
{
    Console.WriteLine();
    Console.WriteLine(message);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("{");
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            Console.Write(matrix[i, j] + ",\t ");
        Console.WriteLine(matrix[i, matrix.GetLength(1) - 1] + "}");
    }
}
//Метод нахождения строки с минимальной суммой элементов
int FindLeastSumRow(int[,] matrix)
{
    int numRows = matrix.GetLength(0);
    int numColumns = matrix.GetLength(1);
    int minSum = int.MaxValue; //максимальное int (в начале сумма в любой строке будет меньше minSum)
    int minRowIndex = -1;
    // задача с гирями наоборот
    for (int i = 0; i < numRows; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < numColumns; j++)
        {
            rowSum += matrix[i, j];
        }
        if (rowSum < minSum)
        {
            minSum = rowSum;
            minRowIndex = i;
        }
    }
    return minRowIndex;
}

int rows = ReadData("Введите количество строк: ");
int columns = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArray(rows, columns, 100, 10); // размер массива и границы значений
Print2DArray(arr2D, "Исходный массив:");
Console.WriteLine("_________________________________________________________");
int minRowIndex = FindLeastSumRow(arr2D);
Console.WriteLine("Строка с наименьшей суммой элементов:");
for (int j = 0; j < columns; j++)
{
Console.Write(arr2D[minRowIndex, j] + " ");
}
Console.WriteLine();
Console.WriteLine($"Номер строки: {minRowIndex+1}");