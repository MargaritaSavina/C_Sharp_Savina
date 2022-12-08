// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int collums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите max: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите min: ");
int min = Convert.ToInt32(Console.ReadLine());

double[,] CreateMatrixArray(int row, int col, int max, int min)
{
double[,] matrix = new double[row, col];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = rnd.NextDouble() * (max - min) + min;
        matrix[i,j] = Math.Round(matrix[i,j],1);
    }
}
    return matrix;
}

void PrintArray(double[,] matrix)
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

double[,] matrArray = CreateMatrixArray(rows, collums, max, min);
PrintArray(matrArray);
