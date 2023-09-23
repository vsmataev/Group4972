// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.

        //Создаем массив
        int[] array = new int[12];
        Random random = new Random();

        // Заполнение массива случайными числами от -9 до 9
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-9, 10); // 10 не включается в диапазон
        }

        Console.WriteLine("Массив случайных чисел:");
        PrintArray(array);

        int positiveSum = 0;
        int negativeSum = 0;

        foreach (int number in array)
        {
            if (number > 0)
            {
                positiveSum += number;
            }
            else if (number < 0)
            {
                negativeSum += number;
            }
        }

        Console.WriteLine($"Сумма положительных элементов: {positiveSum}");
        Console.WriteLine($"Сумма отрицательных элементов: {negativeSum}");

    void PrintArray(int[] array)
    {
    string arrayString = "[" + string.Join(",", array) + "]"; //выводим массив красиво
    Console.WriteLine(arrayString);
    }