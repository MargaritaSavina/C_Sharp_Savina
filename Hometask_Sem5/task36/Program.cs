// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите размер массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int[] CreateArray(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(0,1000);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+",");
    }
}

int SumOdd(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
        {
            sum = sum + arr[i];
        }
    return sum;
}
int[] array = CreateArray(sizeArr);
PrintArray(array);
Console.WriteLine();
int sumNumb = SumOdd(array);
Console.WriteLine("Сумма чисел на нечетных позициях: ");
Console.WriteLine(sumNumb);