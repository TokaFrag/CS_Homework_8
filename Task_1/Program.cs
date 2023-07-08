// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

string PrintArrSingl(int[] array)
{
    return string.Join(", ", array);
}

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

void FindMinSum(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int sizeTempArray = col;

    int[] tempArray = new int[sizeTempArray];
    int[] minArray = new int[sizeTempArray];
    int sum = 0;
    int minSum = 0;
    int lineNumber = 1;

    if (minSum == 0)
    {
        for (int i = 0; i < col; i++)
        {
            minSum = minSum + array[0, i];
            minArray[i] = array[0, i];
        }
    }
    if (sum == 0)
    {
        for (int i = 0; i < col; i++)
        {
            sum = sum + array[1, i];
            tempArray[i] = array[1, i];
        }
    }

    for (int j = 1; j < row; j++)
    {
        if (sum < minSum)
        {
            for (int k = 0; k < col; k++)
            {
                sum = sum + array[j, k];
                minArray[k] = tempArray[k];
            }
            lineNumber++;
        }
        else
        {
            for (int k = 0; k < col; k++)
            {
                sum = sum + array[j, k];
                tempArray[k] = array[j, k];
            }
        }
    }
    Print($"This is the line with the minimum amount {PrintArrSingl(minArray)}, its number {lineNumber}");
}
int[,] array = CreateArray(4, 4, 1, 9);
PrintArr(array);
Console.WriteLine();
FindMinSum(array);