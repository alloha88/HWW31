//  Напишите программу которая принимает на вход число и выдаёт сумму цифр в числе.

int sumNumbers (int x)
{
    int sum = 0;
    while(x > 0)
    {
        int y = x%10;
        x = x/10;
        sum = sum + y;
    }
    return sum;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма цифр в введенном числе равняется" + sumNumbers(number));
