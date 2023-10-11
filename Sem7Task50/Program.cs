// №50 Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.

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
// Метод поиска позиции элемента мо его значению
int[] FindElementPosition(int[,] matrix, int target)
{
    int numRows = matrix.GetLength(0);
    int numColumns = matrix.GetLength(1);

    for (int row = 0; row < numRows; row++)
    {
        for (int col = 0; col < numColumns; col++)
        {
            if (matrix[row, col] == target)
            {
                return new int[] { row, col };
            }
        }
    }

    // Если элемент не найден, возвращаем позицию [-1, -1]
    return new int[] { -1, -1 };
}
// Метод поиска значения эмента по его позиции
void FindElement(int[,] matrix, int row, int column)
{
    if (row >= 0 && row < matrix.GetLength(0) && column >= 0 && column < matrix.GetLength(1))
    {
        Console.WriteLine($"Значение элемента на позиции [{row}, {column}]: {matrix[row, column]}");
    }
    else
    {
        Console.WriteLine("Позиция вне границ массива.");
    }
}


int rows = ReadData("Введите количество строк: ");
int columns = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArray(rows,columns,100,1); //размер массива и границы значений
Print2DArray(arr2D);
int numberToFind = ReadData("Введите число для поиска: ");
int[] position = FindElementPosition(arr2D, numberToFind);

if (position[0] == -1 && position[1] == -1)
{
    Console.WriteLine($"Число {numberToFind} не найдено в массиве.");
}
else
{
    Console.WriteLine($"Число {numberToFind} найдено на позиции [{position[0]}, {position[1]}].");
}
int row = ReadData("Укажите ряд (yevthfwb): ");
int column = ReadData("Укажите столбец: ");
FindElement(arr2D, row, column);