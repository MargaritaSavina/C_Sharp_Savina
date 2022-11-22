// программа выдает количество цифр в числе
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;
int Quantity (int num)
{
    int count = 0;
    while (num > 0)
    {
       num = num / 10;
       count++; 
    }
    return count == 0 ? 1 : count;
}
int dig = Quantity(number);
Console.WriteLine(dig);