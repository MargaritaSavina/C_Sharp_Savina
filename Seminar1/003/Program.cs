// Программа будет выдавать день недели по заданному номеру
Console.WriteLine("Введите число от 1 до 7: ");
int DayWeek = Convert.ToInt32(Console.ReadLine());
if (DayWeek == 1 ) Console.WriteLine("Понедельник ");
else if (DayWeek == 2) Console.WriteLine("Вторник ");
else if (DayWeek == 3) Console.WriteLine("Спеда ");
else if (DayWeek == 4) Console.WriteLine("Четверг ");
else if (DayWeek == 5) Console.WriteLine("Пятница ");
else if (DayWeek == 6) Console.WriteLine("Суббота ");
else if (DayWeek == 7) Console.WriteLine("Воскресенье ");
else if (DayWeek < 1 || DayWeek > 7) Console.WriteLine("Ошибка ввода ");