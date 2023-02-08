// Написать программу, которая обменивает элементы первой строки и последней строки

int[,] CreateMatrix(int lenght, int wigth)
{
    int[,] matrix = new int[lenght, wigth];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(1,10);
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
            Console.Write( $"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void UpdateMatrix (int[,] matrix)
{
    int temp =0;
    int temp1 = matrix.GetLength(0)-1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i==0)
            {
                temp = matrix[i,j];
                matrix[i,j] = matrix[temp1,j];
                matrix[temp1,j]=temp;
            }
        }
    }
}

int ReadInt(string massage)
{
    Console.WriteLine(massage);
    return int.Parse(Console.ReadLine());
}

int lenght = ReadInt ("Строки ");
int wigth = ReadInt ("Столбцы ");

int [,] matrix = CreateMatrix(lenght,wigth);
PrintMatrix(matrix);

UpdateMatrix(matrix);



Console.WriteLine();
PrintMatrix(matrix);