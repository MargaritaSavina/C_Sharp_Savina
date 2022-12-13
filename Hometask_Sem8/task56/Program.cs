// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int collums = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixArray(int row, int col)
{
int[,] matrix = new int[row, col];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = rnd.Next(-10,11);
    }
}
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i,j], 6} ");
            }
        Console.WriteLine();
    }
}

int SmalestSumElem(int[,] matrix)
{
    int minSum = 0;
    int indRow = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minSum += matrix[0,j];
    }
    int sum = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        if (minSum > sum) 
        {
        minSum = sum;
        indRow = i;
        }
    }
    return indRow;
}


int[,] matrArray = CreateMatrixArray(rows, collums);
PrintArray(matrArray);
Console.WriteLine();
Console.WriteLine($"{SmalestSumElem(matrArray)+1} строка");

