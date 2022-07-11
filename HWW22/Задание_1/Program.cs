// Напишите цикл который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double powerNumber(int x, int y)
{
    double power = Math.Pow(x, y);
    return power;
}

Console.WriteLine("Введите число A и число B");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Число A возведенное в степень B равняется" +powerNumber(numberA, numberB));

