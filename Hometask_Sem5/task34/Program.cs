// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите размер массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int[] CreateArray(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(100,1000);
    }
    return arr;
}
int Parity(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;

    }
    return count;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+",");
    }
}
int[] array = CreateArray(sizeArr);
int parityCount = Parity(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Количество четных чисел ->");
Console.WriteLine(parityCount);