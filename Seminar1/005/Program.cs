// Написать программу, которая на вход принимает одно число, а на выоде выдает все целые числа от -N до N
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()); 
int i = -N;
while (i < N+1)
{
    Console.Write(i);
    i++;
}