// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int [,] CreateMatrix(int lenght, int wigth, int left, int right)
{
    int[,] matrix = new int[lenght,wigth];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(left, right);
        }
    }
    return matrix;
}

void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int ReadInt(string massage)
{
    Console.WriteLine(massage);
    return int.Parse(Console.ReadLine());
}

int lenght = ReadInt ("Строки");
int wigth = ReadInt ("Столбцы");
int left = ReadInt ("Min");
int right = ReadInt ("Max");

int[,] matrix= CreateMatrix(lenght,wigth,left,right);
PrintMatrix(matrix);


int sum = 0;
int sum1 =0;
 for (int j = 0; j < matrix.GetLength(1); j++)
{
    sum1=sum1+ matrix[0,j];
}

int ind = 0;
int[] min =new int[matrix.GetLength(1)];
for (int i = 1; i < matrix.GetLength(0); i++)
{
    sum=0;
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sum=sum+ matrix[i,j];
        
    }
    Console.WriteLine("fg"+ sum);
    if (sum<sum1)
    {
        sum1=sum; 
        ind= i;  
    }
}

for (int z = 0; z < min.Length; z++)
{
    min[z]= matrix[ind,z];
    Console.Write($"{min[z]} ");           
}