// 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод создания трехмерного массива и его заполнения без повторения значений
int[,,] GenerateRandom3DArray(int length, int height, int width, int minValue, int maxValue)
{
    int[,,] array3D = new int[length, height, width];
    List<int> uniqueValues = new List<int>(); // создаем список уникальных значений

    // Заполняем список уникальными значениями
    for (int value = minValue; value <= maxValue; value++)
    {
        uniqueValues.Add(value);
    }

    Random rnd = new Random();

    // Заполняем массив уникальными случайными значениями
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < height; j++)
        {
            for (int k = 0; k < width; k++)
            {
                // Проверяем, остались ли еще уникальные значения
                if (uniqueValues.Count == 0)
                {
                    Console.WriteLine("Невозможно заполнить массив, увеличьте диапазон возможных значений.");
                    Environment.Exit(0);
                }

                // Выбираем случайный индекс из списка
                int index = rnd.Next(0, uniqueValues.Count);

                // Получаем значение по индексу и удаляем его из списка (исключаем повторяемость)
                int uniqueValue = uniqueValues[index];
                uniqueValues.RemoveAt(index);

                // Записываем значение в массив
                array3D[i, j, k] = uniqueValue;
            }
        }
    }

    return array3D;
}

void Print3DArray(int[,,] array3D, string message)
{
    Console.WriteLine(message);

    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                string formattedValue = $"{array3D[i, j, k]}({i}, {j}, {k})";
                Console.Write(formattedValue + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int length = ReadData("Введите длину массива: ");
int height = ReadData("Введите высоту массива: ");
int width = ReadData("Введите ширину массива: ");
int[,,] arr3D = GenerateRandom3DArray(length, height, width, 1, 100);
Print3DArray(arr3D, "Ваш массив:");
