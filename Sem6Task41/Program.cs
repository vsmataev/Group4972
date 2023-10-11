// №41 Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// (Задание со звездочкой) Пользователь вводит число нажатий, 
// затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.



double[] numbers = GetNumbers();
int positiveCount = CountPositiveNumbers(numbers);

Console.WriteLine($"Количество положительных чисел: {positiveCount}");


double[] GetNumbers() //метод определения положительных чисел
{
    Console.WriteLine("Введите числа через пробел и нажмите Enter:");
    string input = Console.ReadLine();
    string[] stringNums = input.Split(' '); //задаем массив из введенных чисел
    double[] numbers = new double[stringNums.Length]; //переводим массив в числовой формат
    //заполняем и проверяем только ли цифры введены
    for (int i = 0; i < stringNums.Length; i++)
    {
        if (double.TryParse(stringNums[i], out double number))
        {
            numbers[i] = number;
        }
        else 
        {
            Console.WriteLine($"Некорректное значение: {stringNums[i]}. Введите числа в правильном формате.");
            Environment.Exit(0);
        }
    }

    return numbers;
}

int CountPositiveNumbers(double[] numbers) // считаем количество положительных значений
{
    return numbers.Count(n => n > 0); //лямбда выражение
}
