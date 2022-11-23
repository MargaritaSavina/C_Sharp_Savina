// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
if (size < 0) 
    {
    Console.WriteLine("Размер массива не может быть отрицательным");
    }
else
    {
    Console.WriteLine("Введите нижнюю границу массива");
    int lower = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите верхнюю границу массива");
    int upper = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(lower,upper);
            Console.Write($"{array[i]},");
        }
    }
