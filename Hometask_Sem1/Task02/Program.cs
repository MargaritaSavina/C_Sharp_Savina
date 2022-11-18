// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine()); 
if (number1 == number2)
{
    Console.WriteLine("Числа равны ");
}
else if (number1 > number2)
{
    Console.WriteLine($"max = {number1}, min = {number2} ");
}
else
{
    Console.WriteLine($"max = {number2}, min = {number1} ");
}
