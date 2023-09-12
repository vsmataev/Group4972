﻿// №10 Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

System.Random numberGenerator = new System.Random(); //генератор случайных чисел
    int number = numberGenerator.Next(99,1000); //случайное трехзначное число 
    Console.WriteLine (number); // вывод сгенерированного числа в консоль
    int secondDigit = number/10 %10; //убираем последнюю и первую цифры


    Console.WriteLine($"вторая цифра числа {number} это {secondDigit}");