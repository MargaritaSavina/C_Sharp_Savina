// Напишите программу, которая 
//на вход принимает позиции элемента в двумерном
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
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

int[,] matrArray = CreateMatrixArray(rows, collums);
PrintArray(matrArray);
Console.WriteLine();

Console.WriteLine("Введите i: ");
int rowsPos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите j: ");
int collumsPos = Convert.ToInt32(Console.ReadLine());
if (rowsPos > rows || collumsPos > collums) Console.WriteLine("Нет такого элемента ");
else Console.WriteLine($"[ {matrArray[rowsPos,collumsPos]} ] ");

