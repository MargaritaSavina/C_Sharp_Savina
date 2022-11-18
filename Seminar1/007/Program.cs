// На вход поступает трехзначное число, в ответ выводитс последняя цифра от числа
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 10;
Console.WriteLine(result);

