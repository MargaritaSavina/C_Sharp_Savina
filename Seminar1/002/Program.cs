// на вход поступает 2 числа, программа проверяет, являяется ли одно квадратом другого
Console.WriteLine("Введите число 1: ");
int namber1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число 2: ");
int namber2 = Convert.ToInt32(Console.ReadLine()); 
int square1 = namber1 * namber1;
if (square1 == namber2) 
{
   Console.WriteLine($"Число {namber1} является квадратом числа {namber2} "); 
}
else
{
    Console.WriteLine($"Число {namber1} не является квадратом числа {namber2} ");
} 