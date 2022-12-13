// Сформируйте трёхмерный массив из неповторяющихся 
//двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int collums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int depth = Convert.ToInt32(Console.ReadLine());

int[,,] CreateMatrixArray(int row, int col, int dep)
{
int[,,] matrix = new int[row, col, dep];
 int num = 10;
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            matrix[i,j,k] = num + 2;
            num += 1;
        }
    }
}
    return matrix;
}





void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    Console.Write($"{matrix[i,j,k], 6}  ({i},{j},{k})");
                }
            }
        Console.WriteLine();
    }
}
 

int[,,] matrArray = CreateMatrixArray(rows, collums, depth);
PrintArray(matrArray);
Console.WriteLine();
