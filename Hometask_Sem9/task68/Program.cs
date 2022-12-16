// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите целое натуральное число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое натуральное число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int AckermanFunction(int num1, int num2)
{
    int A = 0;
    if (num1 == 0) return  A += num2 + 1;
    if (num1 > 0 && num2 == 0) return A += AckermanFunction (num1 - 1, 1);
    if (num1 > 0 && num2 > 0) return A += AckermanFunction (num1 - 1, AckermanFunction (num1, num2 - 1));
    return A;
}
int ackermanFunc = AckermanFunction(number1, number2);
Console.WriteLine($"Число Аккермана = {ackermanFunc}");
