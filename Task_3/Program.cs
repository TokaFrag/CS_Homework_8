// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void PrintArr(int[,,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int x = array.GetLength(2);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int z = 0; z < x; z++)
            {
                Print($"{array[i, j, z]} ({i}, {j}, {z})\t");
            }

        }
        Console.WriteLine();
    }
}

void Print(string text)
{
    Console.Write(text);
}

int[,,] CreateArray(int row, int col, int x, int min, int max)
{
    Random random = new Random();
    int[,,] array = new int[row, col, x];
    int size = row * col * x;
    int[] temp = new int[size];
    int number = 0;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        temp[i] = random.Next(min, max + 1);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = random.Next(min, max + 1);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int z = 0; z < x; z++)
            {
                array[i, j, z] = temp[count];
                count++;
            }

        }
    }
    return array;
}

int[,,] array = CreateArray(2, 2, 2, 10, 99);
PrintArr(array);
