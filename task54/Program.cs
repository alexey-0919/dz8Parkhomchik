/* Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Random rnd = new Random();
 int RandomSizeArray()
{
    int z = rnd.Next(3,6);
    return z;
}

int x = RandomSizeArray();
int y = RandomSizeArray(); 

int [,] Array2D = new int [x,y];

FillArray2D(Array2D);
PrintArray2D(Array2D);
SortToLower(Array2D); 
Console.WriteLine();
PrintArray2D(Array2D); 

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
    for (int i = 0; i < Array2D.GetLength(1); i++)
    {
        for (int j = 0; j < Array2D.GetLength(1); j++)
        {
            Console.Write(Array2D[i,j] + "  ");
        }
        Console.WriteLine();
    }
}


void SortToLower(int[,] Array2D)
{
    for (int i = 0; i < Array2D.GetLength(0); i++)
    {
        for (int j = 0; j < Array2D.GetLength(1); j++)
        {
            for (int k = 0; k < Array2D.GetLength(1) - 1; k++)
            {
                if (Array2D[i, k] < Array2D[i, k + 1])
                {
                    int temp = Array2D[i, k + 1];
                    Array2D[i, k + 1] = Array2D[i, k];
                    Array2D[i, k] = temp;
                }
            }
        }
    }
}
