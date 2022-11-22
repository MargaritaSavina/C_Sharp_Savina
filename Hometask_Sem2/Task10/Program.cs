// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
Console.WriteLine("Введите  трехначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
   Console.WriteLine("Введено неверное число "); 
}
else
{
    int secondDigit = SecondDigit(number);
    Console.WriteLine(secondDigit);  
}

int SecondDigit (int num)
    {
    int result = num % 100;
    result = result / 10;
    return result;
    }  


