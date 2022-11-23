// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;
int Sum(int num)
{
    int sum = 0;
    while (num > 0)
    {
       int lastNum = num % 10;
       num = num / 10;
       sum = sum + lastNum; 
    }
    return sum;
}
int summa = Sum(number);
Console.WriteLine(summa);
