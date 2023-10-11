// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

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
void ArrangeRowsMaxToMin(int[,] matrix)
{
    int numRows = matrix.GetLength(0);
    int numColumns = matrix.GetLength(1);

    for (int i = 0; i < numRows; i++)
    {
        // Создаем одномерный массив для каждой строки
        int[] rowArray = new int[numColumns];
        for (int j = 0; j < numColumns; j++)
        {
            rowArray[j] = matrix[i, j];
        }

        // Сортируем элементы строки по убыванию
        Array.Sort(rowArray, (a, b) => b.CompareTo(a)); 

        // Заполняем строку исходного массива заново
        for (int j = 0; j < numColumns; j++)
        {
            matrix[i, j] = rowArray[j];
        }
    }
}


int rows = ReadData("Введите количество строк: ");
int columns = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArray(rows, columns, 100, 10); // размер массива и границы значений
Print2DArray(arr2D, "Исходный массив:");
Console.WriteLine("_________________________________________________________");
ArrangeRowsMaxToMin(arr2D);
Print2DArray(arr2D, "Массив после упорядочивания строк по убыванию:");