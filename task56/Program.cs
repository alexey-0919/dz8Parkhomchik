/*  Задайте прямоугольный двумерный массив. Напишите программу, 
 которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка */


int RandomSizeArray()
{

    int z = Convert.ToInt32(Console.ReadLine());
    return z;
}

int x = RandomSizeArray();
int y = RandomSizeArray(); 
Random rnd = new Random();
int [,] Array2D = new int [x,y];
int [] Array1D = new int [x];
int sum = 0;
int min = 1000;

FillArray2D(Array2D);
PrintArray2D(Array2D);
Console.WriteLine();
Summa(Array2D); 

Console.WriteLine();
MinimalSumma(Array1D);

void MinimalSumma (int [] Array1D)
{
for (int i = 0; i < x-1; i++)
{
   if (Array1D[i] < min)
{
    min = Array1D[i];
}

}
Console.Write("Cумма строки -> " + min); 
}


void FillArray2D(int [,] Array2D)
{
    for (int i = 0; i < Array2D.GetLength(0); i++)
    {
        for (int j = 0; j < Array2D.GetLength(1); j++)
        {
            Array2D [i,j] = rnd.Next(0, 10);
        }
    }
}

void PrintArray2D(int [,] Array2D)
{
    for (int i = 0; i < Array2D.GetLength(0); i++)
    {
        for (int j = 0; j < Array2D.GetLength(1); j++)
        {
            Console.Write(Array2D[i,j] + "  ");
        }
        Console.WriteLine();
    }
}


void Summa(int[,] Array2D)
{
    
    for (int i = 0; i < Array2D.GetLength(0); i++)
    {
        for (int j = 0; j < Array2D.GetLength(1); j++)
        {
            sum = sum + Array2D[i,j];
            
        }
        Array1D[i] = sum;
            Console.Write(Array1D[i] + "  ");
        Console.WriteLine();
    sum = 0;
   
    }

    
    Console.WriteLine();
}


