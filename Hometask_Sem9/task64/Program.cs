// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Введите целое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;
ConclusionNaturNum(number);

void ConclusionNaturNum(int num) 
{
    if (num == 0) return;
    Console.Write($"{num} ");
    ConclusionNaturNum(num - 1);
}
