// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
double Cube(int num)
    {
         double cube = Math.Pow(num,3);
         return cube;
    }
if (number >= 0)
{
    for (int i = 1; i < number + 1; i++)
        {
            double cubeNumber = Cube(i);
            Console.WriteLine(cubeNumber);
        }
}
else
{
    for (int i = -1; i > number - 1; i--)
        {
            double cubeNumber = Cube(i);
            Console.WriteLine(cubeNumber);
        }
}        
