// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).2147483648 || number > 2147483647
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result;
if (number < 100)
{
    Console.WriteLine("Третьего числа нет");
}

 else if (number > 99 && number < 1000)
{
result = number % 10;
Console.WriteLine(result);
}


 else if (number > 999 && number < 10000)
{
result = number % 100;
result = result / 10;
Console.WriteLine(result);
}

else if (number > 9999 && number < 100000)
{
result = number % 1000;
result = result / 100;
Console.WriteLine(result);
}


else if (number > 99999 && number < 1000000)
{
result = number % 10000;
result = result / 1000;
Console.WriteLine(result);
}

else if (number > 999999 && number < 10000000)
{
result = number % 100000;
result = result / 10000;
Console.WriteLine(result);
}


else if (number > 9999999 && number < 100000000)
{
result = number % 1000000;
result = result / 100000;
Console.WriteLine(result);
}


else if (number > 99999999 && number < 1000000000)
{
result = number % 10000000;
result = result / 1000000;
Console.WriteLine(result);
}


else if (number > 999999999 && number < 2147483647)
{
result = number % 100000000;
result = result / 10000000;
Console.WriteLine(result);
}


