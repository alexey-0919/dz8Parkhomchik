/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
 */
Random rnd = new Random();
int RandomSizeArray()
{
    int z = Convert.ToInt32(Console.ReadLine());
    return z;
}

Console.WriteLine("Введите размер 1 матрицы");
int x = RandomSizeArray();
int y = RandomSizeArray();

Console.WriteLine("Введите размер 2 матрицы");
int a = RandomSizeArray();
int b = RandomSizeArray();
Console.WriteLine();

int [,] Array2D1 = new int [x,y];
int [,] Array2D2 = new int [a,b];
int [,] ResultArray = new int [x,b];

if (y != a)
{
Console.WriteLine("Матрицы нельзя перемножить"); 
return; 
}

FillArray2D1(Array2D1);
Console.WriteLine();
FillArray2D2(Array2D2);
Console.WriteLine();
ProizvedenieArray(Array2D1, Array2D2, ResultArray);


void FillArray2D1(int [,] Array2D1)
{
    for (int i = 0; i < Array2D1.GetLength(0); i++)
    {
        for (int j = 0; j < Array2D1.GetLength(1); j++)
        {
            Array2D1 [i,j] = rnd.Next(0, 10);
            Console.Write(Array2D1[i,j] + "  ");
        }
        Console.WriteLine();
    }
}

void FillArray2D2(int [,] Array2D2)
{
    for (int i = 0; i < Array2D2.GetLength(0); i++)
    {
        for (int j = 0; j < Array2D2.GetLength(1); j++)
        {
            Array2D2 [i,j] = rnd.Next(0, 10);
            Console.Write(Array2D2[i,j] + "  ");
        }
        Console.WriteLine();
    }
}


void ProizvedenieArray (int [,] Array2D1, int [,] Array2D2, int [,] ResultArray)
{
    for (int i = 0; i < Array2D1.GetLength(0); i++)
    {
        for (int j = 0; j < Array2D2.GetLength(1); j++)
        {
            for (int p = 0; p < Array2D2.GetLength(0); p++)
            {
                ResultArray [i,j] += Array2D1[i,p] * Array2D2[p,j] ;
            }
           
            Console.Write(ResultArray[i,j] + "  ");
        }
        Console.WriteLine();
    }
}

