/*Задача 27: Напишите программу, которая принимает
на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int numberForLength = number; //отдельная переменная для расчёта длины числа

int LengthOfNumber(int numberForLength) //метод для расчёта длины числа, чтобы не использовать string
{
    int lengthOfNumber = 0;

    while (numberForLength > 0)
    {
        lengthOfNumber++;
        numberForLength = numberForLength/10;
    }
    
    return lengthOfNumber;
}

int GetSummDigit(int number, int lengthOfNumber) //метод для подсчёта суммы цифр числа
{
    int summ = 0;
    int lastDigit = 0;

    for (int i = 0; i < lengthOfNumber; i++) //цикл для подсчёта суммы цифр в числа
    {
        lastDigit = number % 10;
        summ += lastDigit;
        number /= 10;
    }

    return summ;
}

Console.WriteLine("Сумма цифр числа " + number + " равна: " + GetSummDigit(number, LengthOfNumber(numberForLength)) + ".");