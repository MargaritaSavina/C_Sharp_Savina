// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int Degree(int numA, int numB)
{
    int result = numA;
    int i = 1;
    while (i < numB)
        {   
            result = result * numA;
            i++;
        }
    return numB == 0 ? 1 : result;
}
int degree = Degree(numberA, numberB);
Console.WriteLine(degree);
