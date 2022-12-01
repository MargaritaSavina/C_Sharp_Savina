// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
Console.WriteLine("Введите размер массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите max: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите min: ");
int min = Convert.ToInt32(Console.ReadLine());
double[] CreateArray(int size, int max, int min)
{
double[] arr = new double[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(arr[i],1);
    }
    return arr;
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+"|");
    }
}
double MaxNumber(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
        }
    return max;
}

double MinNumber(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min) min = arr[i];
        }
    return min;
}

double[] array = CreateArray(sizeArr,max,min);
PrintArray(array);
double maxNumb = MaxNumber(array);
double minNumb = MinNumber(array);
Console.WriteLine();
Console.WriteLine("Разность -> ");
Console.WriteLine(maxNumb-minNumb);
