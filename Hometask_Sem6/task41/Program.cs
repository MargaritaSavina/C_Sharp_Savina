// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] EnterArray(int s)// int s - размер массива
{
    double[]arr = new double[s];
    Console.WriteLine("Введите массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        
        int num = Convert.ToInt32(Console.ReadLine());
        arr[i] = num;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+",");
    }
}
double[] array = EnterArray(size);
PrintArray(array);
double number = Positive(array);
Console.Write("  ->  "+ number);

 double Positive(double[] arr)
 {
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0) count++;
        }
    return count;
 }