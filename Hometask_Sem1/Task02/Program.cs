// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число 1: ");
int namber1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число 2: ");
int namber2 = Convert.ToInt32(Console.ReadLine()); 
if (namber1 == namber2)
{
    Console.WriteLine("Числа равны ");
}
else if (namber1 > namber2)
{
    Console.WriteLine($"max = {namber1}, min = {namber2} ");
}
else
{
    Console.WriteLine($"max = {namber2}, min = {namber1} ");
}
