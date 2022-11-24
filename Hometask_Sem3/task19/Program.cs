// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;
if (number < 10000 || number > 99999) { Console.WriteLine("Число не пятизначное"); }
else
{
    int Palindrome(int num)
    {
        int leftNum = num / 1000;
        int num1 = leftNum / 10;
        int num2 = leftNum % 10;
        int invertleftNum = num1 + num2 * 10;
        int rightNum = num % 100;
        
        int result = rightNum == invertleftNum ? 1 : 0;
        return result;
    }
    int res = Palindrome(number);
    if (res == 1) 
    {
        Console.WriteLine($"{number} --> Да ");
    }
    else 
    {
        Console.WriteLine($"{number} --> Нет ");
    }
}