// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).2147483648 || number > 2147483647
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result;
int third;
if (number < 100)
{
    Console.WriteLine("Третьего числа нет");
}

 else if (number > 99 && number < 1000)
{
third = ThirdDigit1(number);
Console.WriteLine(third);
}


 else if (number > 999 && number < 10000)
{
third = ThirdDigit2(number);
Console.WriteLine(third);
}

else if (number > 9999 && number < 100000)
{
third = ThirdDigit3(number);
Console.WriteLine(third);
}


else if (number > 99999 && number < 1000000)
{
third = ThirdDigit4(number);
Console.WriteLine(third);
}

else if (number > 999999 && number < 10000000)
{
third = ThirdDigit5(number);
Console.WriteLine(third);
}


else if (number > 9999999 && number < 100000000)
{
third = ThirdDigit6(number);
Console.WriteLine(third);
}


else if (number > 99999999 && number < 1000000000)
{
third = ThirdDigit7(number);
Console.WriteLine(third);
}


else if (number > 999999999 && number < 2147483647)
{
third = ThirdDigit8(number);
Console.WriteLine(third);
}

int ThirdDigit1(int num)
    {
    result = number % 10;
    return result;
    } 
int ThirdDigit2(int num)
    {
    result = number % 100;
    result = result / 10;
    return result;
    } 
int ThirdDigit3(int num)
    {
    result = number % 1000;
    result = result / 100;
    return result;
    } 
int ThirdDigit4(int num)
    {
    result = number % 10000;
    result = result / 1000;
    return result;
    } 
int ThirdDigit5(int num)
    {
    result = number % 100000;
    result = result / 10000;
    return result;
    } 
int ThirdDigit6(int num)
    {
    result = number % 1000000;
    result = result / 100000;
    return result;
    } 
    int ThirdDigit7(int num)
    {
    result = number % 10000000;
    result = result / 1000000;
    return result;
    } 
    int ThirdDigit8(int num)
    {
    result = number % 100000000;
    result = result / 10000000;
    return result;
    } 

