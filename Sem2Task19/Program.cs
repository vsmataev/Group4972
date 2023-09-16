// Внутри класса Answer напишите метод IsPalindrome, 
// который принимает на вход пятизначное число number и проверяет, 
// является ли оно палиндромом.
// Метод должен проверить является ли число пятизначным, 
// в противном случае - вывести Число не пятизначное и False в следующей строке.
// Для остальных чисел вернуть True или False.

using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
      // Введите свое решение ниже
    if (number < 10000 || number > 99999) //проверка на пятизначность
        {
            Console.WriteLine("Число не пятизначное.");
            return false;
        }
        // перестраиваем число задом наперед
        int originalNumber = number; 
        int reversedNumber = 0;

        while (number > 0)
        {
            int digit = number % 10; 
            reversedNumber = reversedNumber * 10 + digit; 
            number /= 10; 
        }

        return originalNumber == reversedNumber; //если перестроенное число и оригинальное совпадают
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}