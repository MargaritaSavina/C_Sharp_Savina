// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
int ratios = 4;
double[] EnterArray(int size)
{
    double[]arr = new double[size];
    Console.WriteLine("Введите коэффициенты: ");
    for (int i = 0; i < arr.Length; i++)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        arr[i] = num;
    }
    return arr;
}

double[] array = EnterArray(ratios);
if (array[2] == 0 && array[0] == 0) Console.WriteLine("Решения нет ");
double[] Equation(double[] arr)
{
    double[] arrXY = new double[2];
    // arr[0] = k1;       arr[1] = b1;
    // arr[2] = k2;       arr[3] = b2;
    double x = (arr[1] - arr[3]) / (arr[2] - arr[0]); 
    double y = arr[0] * x + arr[1]; 
    arrXY[0] = x;
    arrXY[1] = y;       
    return arrXY;       
}
double[] arrayXY = Equation(array);
void PrintArray(double[] arr)
{
    Console.Write("("+arr[0]+";" + arr[1]+ ")");
}
PrintArray(arrayXY);
