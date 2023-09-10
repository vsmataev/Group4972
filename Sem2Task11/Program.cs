// 11. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе убирает вторую
// цифру этого числа. 237 => 27

void Variant1() //решение преподавателя
{
System.Random numberGenerator = new System.Random(); //генератор случайных чисел
    int number1 = numberGenerator.Next(99,1000); //случайное трехзначное число 
    Console.WriteLine (number1); // вывод сгенерированного числа в консоль
    int firstDigit = number1/100; //первая цифра 237/100 => 2,37 (остаток при этом не учитывается)
    int lastDigit = number1%10; // вторая цифра остаток от деления числа на 10 237/10 => 7 (остаток считается как целое число)
number1 = firstDigit*10+lastDigit; // умножаем первую цифру на 10 2*10 = 20 и прибавляем вторую цифру 20+7=27
Console.WriteLine(number1);//результат
}
// решение через массив
void Variant2()
{
System.Random numberGenerator = new System.Random(); //генератор случайных чисел
    int number2 = numberGenerator.Next(99,1000); //случайное трехзначное число 
    Console.WriteLine (number2); // вывод сгенерированного числа в консоль
    char[] digitChar = number2.ToString().ToCharArray(); // создание массива
    System.Console.Write(digitChar[0]); //вывод первого элемента
    System.Console.Write(digitChar[2]); //вывод второго элемента
}

// void Variant3() //разобраться потом
// {
// System.Random numberGenerator = new System.Random(); //генератор случайных чисел
//     int number3 = numberGenerator.Next(99,1000); //случайное трехзначное число 
//     Console.WriteLine (number3); // вывод сгенерированного числа в консоль
// }
Variant1();
Variant2();
