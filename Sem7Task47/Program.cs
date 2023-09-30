// №47 Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// и чтоб все были разного цвета

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Создание и заполнение двумерного массива (по сути - таблица)
double[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    Random rnd = new Random();
    double[,] array2D = new double[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            double randomValue = rnd.NextDouble() * (topBorder - downBorder) + downBorder;
            array2D[i, j] = Math.Round(randomValue, 1); // Округляем до десятых
        }
    }

    return array2D;
}

void Print2DArray(double[,] matrix)
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

void Print2DArrayColor(double[,] matrix)
{
    ConsoleColor[] colors = new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green,
                                        ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White,
                                        ConsoleColor.Yellow };

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // Используем один и тот же объект Random для получения цветов
            Console.ForegroundColor = colors[rnd.Next(0, 16)];
            Console.Write(matrix[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

double[,] arr2D = Fill2DArray(row,column,100,10); //размер массива и границы значений
Print2DArray(arr2D);
Print2DArrayColor(arr2D);