// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Введите количество строк матрицы1: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы1: ");
int collums1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк матрицы2: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы2: ");
int collums2 = Convert.ToInt32(Console.ReadLine());

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

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        
        for (int k = 0; k < matrix2.GetLength(1); k++)
        {
            sum = 0;
            for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                     sum += matrix1[i,j] * matrix2[j,k];
                     
                }
        result[i,k] = sum;
        }
        
    }
    return result;
}

int[,] matrArray1 = CreateMatrixArray(rows1, collums1);
PrintArray(matrArray1);
Console.WriteLine();
int[,] matrArray2 = CreateMatrixArray(rows2, collums2);
PrintArray(matrArray2);
Console.WriteLine();
if (rows1 != collums2) 
{
    Console.WriteLine("Произведение не может быть вычислено");
}
else
{
    int[,] resultArray = MatrixProduct(matrArray1,matrArray2);
    PrintArray(resultArray);
}
