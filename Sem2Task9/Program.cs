// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
void Variant1()
{
    Console.WriteLine("способ 1");

    System.Random numberGenerator = new System.Random(); //генератор случайных чисел
    int number = numberGenerator.Next(10,100); //случайное число от 10 до 100
    Console.WriteLine (number);
    int firstDigit = number/10; //делим на 10 и получаем первую цифру числа
    int secondDigit = number%10; //находим остаток от деления на 10 - это буде вторая цифра числа

    if (firstDigit > secondDigit) // сравниваем числа и выводим результат
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}
// второй способ
void Variant2()
{
Console.WriteLine("способ 2");
System.Random numberGenerator1 = new System.Random(); //генератор случайных чисел
int number1 = numberGenerator1.Next(10,100); //случайное число от 10 до 100
Console.WriteLine (number1);
Console.WriteLine ((number1/10>number1%10)?(int)(number1/10):(int)(number1%10)); //тернарный оператор
}
//третий способ
void Variant3()
{
    Console.WriteLine("способ 3");

    System.Random numberGenerator = new System.Random(); //генератор случайных чисел
    int number = numberGenerator.Next(10,100); //случайное число от 10 до 100
    Console.WriteLine (number); // вывод сгенерированного числа в консоль
    
    char[] digitChar = number.ToString().ToCharArray(); // создаем массив и переводим его в строку и разбираем по цифрам
    Console.WriteLine((int)digitChar[0]>(int)digitChar[1]?digitChar[0]:digitChar[1]);
    // <условие> ? <вариант1> : <вариант2>
}
//если закоментировать один из вариантов (например первый) - то он не будет работать
Variant1(); 
Variant2();
Variant3();