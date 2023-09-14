// №10 Напишите программу, 
// которая принимает на вход 
// трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

  System.Random numberGenerator = new System.Random(); //генератор случайных чисел
    int number = numberGenerator.Next(100,1000); //случайное трехзначное число
    Console.WriteLine (number);
    int thirdNum = number/10 %10; //последовательно убираем последнюю и первую цифры
    Console.WriteLine($"Вторая цифра это {thirdNum}");