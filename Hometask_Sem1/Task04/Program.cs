// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число 1: ");
int namber1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число 2: ");
int namber2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число 3: ");
int namber3 = Convert.ToInt32(Console.ReadLine()); 
int max = namber1;
if (max < namber2) max = namber2;
else if (max < namber3) max = namber3;
Console.Write("max =  ");
Console.WriteLine(max);
