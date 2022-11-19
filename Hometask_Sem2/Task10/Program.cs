// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
Console.WriteLine("Введите  трехначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
    Console.WriteLine("Введено не трехзначное число ");
}
else 
{
int result = number % 100;
int SecondNumber = result / 10;
Console.WriteLine(SecondNumber);
}