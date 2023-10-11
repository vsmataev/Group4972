// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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
//Метод умножения матиц
int[,] ArrayProduct(int[,] matrix1, int[,] matrix2)
{
    int numRows1 = matrix1.GetLength(0);
    int numColumns1 = matrix1.GetLength(1);
    int numRows2 = matrix2.GetLength(0);
    int numColumns2 = matrix2.GetLength(1);

    // Проверка на уможаемость
    if (numColumns1 != numRows2)
    {
        Console.WriteLine("Количество столбцов первого массива должно совпадать с количеством строк второго массива");
        Environment.Exit(0);
    }
    // создаем массив-результат и заполняем его
    int[,] result = new int[numRows1, numColumns2];
    for (int i = 0; i < numRows1; i++)
    {
        for (int j = 0; j < numColumns2; j++)
        {
            int sum = 0;
            for (int k = 0; k < numColumns1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            result[i, j] = sum;
        }
    }
    return result;
}

int rows = ReadData("Введите количество строк в первом массиве: ");
int columns = ReadData("Введите количество столбцов в первом массиве: ");
int rows2 = ReadData("Введите количество строк во втором массиве: ");
int columns2 = ReadData("Введите количество столбцов во втором массиве: ");
int[,] arr1 = Fill2DArray(rows, columns, 10, 1); // размер первого массива и границы значений
Print2DArray(arr1, "Первый массив:");
Console.WriteLine("_________________________________________________________");
int[,] arr2 = Fill2DArray(rows2, columns2, 10, 1); // размер второго массива и границы значений
Print2DArray(arr2, "Второй массив:");
Console.WriteLine("_________________________________________________________");
int[,] resultArray = ArrayProduct(arr1, arr2);
Print2DArray(resultArray, "Результат перемножения матриц:");