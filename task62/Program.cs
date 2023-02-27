/* 
int RandomSizeArray()
{

    int z = Convert.ToInt32(Console.ReadLine());
    return z;
}

int x = RandomSizeArray();
int y = RandomSizeArray(); 
Random rnd = new Random();
int [,] Array2D = new int [x,y];
int size = x*y;
int number = 01;
FillArray2D(Array2D);

for(int k = 0; k < size; k++)
{
    for (int i = 0; i < Array2D.GetLength(0); i++)
    {
        
        
    }
}


void FillArray2D(int [,] Array2D)
{
    for (int i = 0; i < Array2D.GetLength(0); i++)
    {
        for (int j = 0; j < Array2D.GetLength(1); j++)
        {
            while (j<y)
            Array2D [i,j] = number;
            while (j=y-1 && i < x)
            Array2D [i,j] = number;
            while ()
            number++;
            if (number<=10)
            Console.Write($" {Array2D[i,j] + "  "}");
            else
            Console.Write(Array2D[i,j] + "  ");
        }
        Console.WriteLine();
    }
}

 */

 Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(nums);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        /* Console.Write("[ "); */
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]<=9)
            Console.Write($" {array[i,j] + "   "}");
            else if (array[i,j] > 9 && array[i,j] < 100)
            Console.Write(array[i,j] + "   ");
            else if (array[i,j] > 99 && array[i,j] < 1000)
            Console.Write(array[i,j] + "  ");
             else if (array[i,j] > 999 && array[i,j] < 10000)
            Console.Write(array[i,j] + " ");
            /* Console.Write(array[i, j] + " "); */
        }
        /* Console.Write("]"); */
        Console.WriteLine("");
    }
}