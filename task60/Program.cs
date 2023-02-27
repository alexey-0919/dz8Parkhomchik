

Random rnd = new Random();
int RandomSizeArray()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

Console.WriteLine("Введите размер массива");
int x = RandomSizeArray();
int y = RandomSizeArray();
int z = RandomSizeArray();

if (x*y*z > 90)
{
    Console.WriteLine("Неподходящий размер массива");
    return;
}
int maxsize = 89;
int[,,] Arr3D = new int [x,y,z];
int size = x * y* z;
int[] Arr = new int [maxsize];

int onenumber = 10;

/* int [] arr1089 = new int [maxsize]; */

for(int i = 0; i < Arr.Length; i++)
{
    Arr[i] = onenumber;
    onenumber++;
}


for (int i = 0; i < Arr.Length; i++)
{
    int RandomInd = rnd.Next(0,Arr.Length);
    int temp = Arr[i];
    Arr[i] = Arr[RandomInd];
    Arr[RandomInd] = temp;
}

int ArrIndex = 0;

FillArr3D(Arr3D);

void FillArr3D (int [,,] Arr3D)
{
    for (int i = 0; i < Arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < Arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < Arr3D.GetLength(2); k++)
            {
                Arr3D[i,j,k] = Arr[ArrIndex++];
                Console.Write($"[{i},{j},{k}] - {Arr3D[i,j,k]}" + "  ");
            }
           
                Console.WriteLine();
            
        }
        Console.WriteLine();
    }
} 

