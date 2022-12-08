// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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

void PrintArray2D(int[,] matrix)
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

void PrintArray(double[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write($"{matrix[i], 6} ");
    }
}

double[] AverageCollums(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    
    int j = 0;
    
    while (j < matrix.GetLength(1))
        {
            int i = 0;
            double sum = 0;
            while (i < matrix.GetLength(0))
            {
                sum = sum + matrix[i,j];
                i++;
            } 
            average[j] = sum /  matrix.GetLength(0);
            average[j] = Math.Round(average[j],1);
            j++;
        }
    return average;
}


int[,] matrArray = CreateMatrixArray(rows, collums);
PrintArray2D(matrArray);
Console.WriteLine();
double[] averCol = AverageCollums(matrArray);
Console.WriteLine("Среднее арифметическое столбцов: ");
PrintArray(averCol);