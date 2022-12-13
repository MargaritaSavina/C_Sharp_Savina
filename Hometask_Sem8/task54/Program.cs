// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int[,] SortDescendingRows(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int repeat = 0; repeat < matrix.GetLength(1) - 1; repeat++)
                {  
                    for (int j = 1; j < matrix.GetLength(1); j++)
                        {
                            
                            if (matrix[i,j] > matrix[i,j - 1]) 
                            {
                                int t = matrix[i,j];
                                matrix[i,j] = matrix[i,j - 1];
                                matrix[i,j - 1] = t;
                            }           
                        }
                } 
        }
    return matrix;
}

int[,] matrArray = CreateMatrixArray(rows, collums);
PrintArray(matrArray);
Console.WriteLine();
int[,] averCol = SortDescendingRows(matrArray);
PrintArray(averCol);