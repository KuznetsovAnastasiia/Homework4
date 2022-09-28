//  Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16

int numberA = 0;
int numberB = 0;

for (int i = 0; i < 2; i++) // цикл для введения чисел A и B
{
    Console.WriteLine("Введите число: ");
    if (i == 0)
    {
        numberA = Convert.ToInt32(Console.ReadLine());
    }
    if (i == 1)
    {
        numberB = Convert.ToInt32(Console.ReadLine());
    }
}

double GetPower(int numberA, int numberB) // метод для расчёта результата возведения числа A в степень B
{
    double power = 1;
    
    for (int i = 1; i <= numberB; i++) // цикл для расчёта результата возведения числа A в степень B
        {
            power = power * numberA;
        }
    
    return power;
}

Console.WriteLine("Число 'A' в степени 'B' равно: " + GetPower(numberA, numberB) + ".");