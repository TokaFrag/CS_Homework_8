// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SortArray(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int sizeTempArray = col;
    int countRow = 0;
    int[] tempArray = new int[sizeTempArray];
    int[,] newArray = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            tempArray[j] = array[i, j];
        }
        Array.Sort(tempArray);

        if (countRow <= col)
        {
            for (int k = 0; k < sizeTempArray; k++)
            {
                newArray[countRow, k] = tempArray[k];
            }
            countRow++;
        }
    }
    PrintArr(newArray);

}

int[,] array = CreateArray(3, 3, 1, 9);
PrintArr(array);
Console.WriteLine();
SortArray(array);