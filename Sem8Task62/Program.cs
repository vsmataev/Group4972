//  Задача 62: Заполните спирально массив 4 на 4.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] CreateSpiralArray(int size, int minValue, int maxValue)
{
    int[,] spiralArray = new int[size, size];
    int num = minValue;
    //задаем границы спирали (должны смещаться к центру по мере "закручивания")
    int rowStart = 0, rowEnd = size - 1, colStart = 0, colEnd = size - 1;

        while (rowStart <= rowEnd && colStart <= colEnd)
        {
            // Заполняем верхнюю строку слева направо
            for (int i = colStart; i <= colEnd; i++)
            {
                spiralArray[rowStart, i] = num++;
            }
            rowStart++;

            // Заполняем правый столбец сверху вниз
            for (int i = rowStart; i <= rowEnd; i++)
            {
                spiralArray[i, colEnd] = num++;
            }
            colEnd--;

            // Заполняем нижнюю строку справа налево
            if (rowStart <= rowEnd)
            {
                for (int i = colEnd; i >= colStart; i--)
                {
                    spiralArray[rowEnd, i] = num++;
                }
                rowEnd--;
            }

            // Заполняем левый столбец снизу вверх
            if (colStart <= colEnd)
            {
                for (int i = rowEnd; i >= rowStart; i--)
                {
                    spiralArray[i, colStart] = num++;
                }
                colStart++;
            }
        }

        return spiralArray;
    }

void Print2DArray(int[,] matrix, string message)
{
    Console.WriteLine();
     Console.WriteLine(message);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
}

int sideValue = ReadData("Укажите размер: ");
int[,] array = CreateSpiralArray(sideValue, 1, sideValue * sideValue); //квадрат стороны, чтоб хватило
Print2DArray(array, "Спиральный массив:");
