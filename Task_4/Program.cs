// Напишите программу, которая заполнит спирально массив 4 на 4.

void PrintArr(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (array[i, j] < 10)
            {
                Print($"0{array[i, j]}\t");
            }
            else
            {
                Print($"{array[i, j]}\t");
            }
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
    int[,] array = new int[row, col];
    int size = row * col;
    int number = 1;
    int i = 0;
    int j = 0;
    while (number <= size)
    {
        array[i, j] = number;
        number++;
        if (i <= j + 1 && i + j < col - 1)
            j++;
        else if (i < j && i + j >= row - 1)
            i++;
        else if (i >= j && i + j > col - 1)
            j--;
        else
            i--;
    }
    return array;
}


int[,] array = CreateArray(4, 4, 1, 9);
PrintArr(array);
