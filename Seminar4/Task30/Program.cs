// Напишите программу, котора выводит массив из 8 элементов, 
//заполненныйнулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
int[] array = new int[8];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0,2);
    Console.Write(array[i]);
}

