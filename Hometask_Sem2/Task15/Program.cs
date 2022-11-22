// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());
if (dayWeek == 1 )  DayWeek(dayWeek);        //пн
else if (dayWeek == 2) DayWeek(dayWeek);     //вт
else if (dayWeek == 3) DayWeek(dayWeek);     //ср
else if (dayWeek == 4) DayWeek(dayWeek);     //чт
else if (dayWeek == 5) DayWeek(dayWeek);     //пт
else if (dayWeek == 6) DayWeekend(dayWeek);  //сб
else if (dayWeek == 7) DayWeekend(dayWeek);  //вс
else if (dayWeek < 1 || dayWeek > 7) Console.WriteLine("Ошибка ввода ");
void DayWeekend(int day)
{ 
    Console.Write($"{day}--> Да");
}
void DayWeek(int day)
{ 
    Console.Write($"{day}--> Нет");
}