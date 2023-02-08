// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
int[,] CreateMatrix(int lenght, int wigth, int left, int right)
{
    int[,] matrix = new int[lenght,wigth];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(left,right);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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


/*void UpdateMatrix(int[,] matrix)
{
    int max =0;
    int temp =0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                if (matrix[i,y]>max)
                {
                    max = matrix[i,y];
                    temp=matrix[i,j];
                    matrix[i,j]= max;
                    matrix[i,y]=temp;
                }
            }
        }
    }
}*/

int ReadInt(string massage)
{
    Console.WriteLine(massage);
    return int.Parse(Console.ReadLine());
}

int lenght = ReadInt ("Строки ");
int wigth = ReadInt ("Столбцы ");
int left = ReadInt ("min");
int right = ReadInt ("max ");

int[,] matrix = CreateMatrix(lenght,wigth,left,right);
PrintMatrix(matrix);


    //int max =0;
    int temp =0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            for (int y = 0; y < matrix.GetLength(1)-1; y++)
            {
                if (matrix[i,y]<matrix[i,y+1])
                {
                    temp=matrix[i,y];
                    matrix[i,y]= matrix[i,y+1];
                    matrix[i,y+1]=temp;

                }
            }
        }
    }


Console.WriteLine();
    PrintMatrix(matrix);
