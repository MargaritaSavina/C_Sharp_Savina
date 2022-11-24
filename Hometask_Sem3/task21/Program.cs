// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты первой точки ");
Console.WriteLine("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки ");
Console.WriteLine("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double Distance(int x1,int y1,int z1,int x2,int y2,int z2)
    {
        double dist = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
        return dist;
    }
double distanse = Distance(x1,y1,z1,x2,y2,z2);
Console.WriteLine(distanse);

