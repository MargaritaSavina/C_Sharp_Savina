// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
Console.WriteLine("Введите целое натуральное число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое натуральное число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 < 0 || number2 < 0)
{
    Console.WriteLine("Введены ненатуральные числа ");
}
else
{
    int summa = 0;
if (number1 < number2)
{
    summa = ConclusionNaturNum(number1, number2);
}
else
{
    summa =ConclusionNaturNum(number2, number1);
}
Console.WriteLine($"Сумма = " + summa);
int ConclusionNaturNum(int num1, int num2) 
{
    int sum = 0;
    if (num2 < num1) return sum;
    sum += num1 + ConclusionNaturNum(num1 + 1, num2);  
    return sum;
}
}
