// На вход поступает число А, найти сумму(произведение) всех чисел от 1 до А
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDig (int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        sum = sum * i;
    }
    return sum;
}
int sumDig = SumDig (number);
Console.WriteLine(sumDig);