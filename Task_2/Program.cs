// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void PrintArr(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Print($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Print(string text)
{
    Console.Write(text);
}

int[,] CreateArray(int row, int col, int min, int max)
{
    Random random = new Random();
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = random.Next(min, max + 1);
        }
    }
    return array;
}

void GetProductMatrices(int[,] array1, int[,] array2)
{
    int row1 = array1.GetLength(0);
    int col2 = array2.GetLength(1);
    int[,] newArray = new int[row1, col2];

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for (int k = 0; k < newArray.GetLength(1); k++)
            {
                newArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    PrintArr(newArray);
}
int[,] array1 = CreateArray(3, 2, 1, 9);
int[,] array2 = CreateArray(2, 2, 1, 9);
Console.WriteLine("This is the first matrix");
PrintArr(array1);
Console.WriteLine("This is the second matrix");
PrintArr(array2);
Console.WriteLine("This is the product of matrices");
GetProductMatrices(array1, array2);