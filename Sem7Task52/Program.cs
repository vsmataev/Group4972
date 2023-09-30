// 52 Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом
// столбце.

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
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
// Метод поиска среднего арифметического
double[] CalculateColumnAverages(int[,] matrix)
{
    int numRows = matrix.GetLength(0); //ряды
    int numColumns = matrix.GetLength(1); //столбцы
    double[] columnAverages = new double[numColumns]; //Массив для хранения средних значений

    for (int col = 0; col < numColumns; col++)
    {
        double sum = 0;
        for (int row = 0; row < numRows; row++)
        {
            sum += matrix[row, col];
        }
        columnAverages[col] = sum / numRows; // Среднее значение для столбца
    }

    return columnAverages;
}


int rows = ReadData("Введите количество строк: ");
int columns = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArray(rows, columns, 100, 10); // размер массива и границы значений
Print2DArray(arr2D);

double[] averages = CalculateColumnAverages(arr2D);

for (int i = 0; i < averages.Length; i++)
{
    Console.WriteLine($"Среднее значение для столбца {i + 1}: {averages[i]}");
}
