/*// Задача 1
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void Reverse2dArray(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0) - 1; i++)
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Reverse2dArray(myArray);
Show2dArray(myArray);*/








/*// Задача 3
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] CreateRandom2dArray()
{
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeLines(int[,] nums, int firstLine, int secondLine)
{
    if(firstLine == secondLine || firstLine < 0 || secondLine < 0 || firstLine >= nums.GetLength(0) || secondLine >= nums.GetLength(0))
        Console.WriteLine("Error!");
    else
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            int temp = nums[firstLine, j];
            nums[firstLine, j] = nums[secondLine, j];
            nums[secondLine, j] = temp;
        }
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
ChangeLines(myArray, 1, 3);
Show2dArray(myArray);*/








/*// Задача 4
// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a max possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] MinPosition(int[,] array)
{
    int minPosRow = 0;
    int minPosColums = 0;

    int[] indexes = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < array[minPosRow, minPosColums])
            {
                minPosRow = i;
                minPosColums = j;
            }

    indexes[0] = minPosRow;
    indexes[1] = minPosColums;

    return indexes;
}

int[,] DeleteRowColum(int[,] array, int row, int colum)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0, a = 0; i < array.GetLength(0); i++, a++)
    {
        if (i == row) a--;
        else
            for (int j = 0, b = 0; j < array.GetLength(1); j++, b++)
            {
                if (j == colum) b--;
                else newArray[a, b] = array[i, j];
            }
    }
    return newArray;
}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

int[] minPos = MinPosition(myArray);

int i = minPos[0];
int j = minPos[1];

int[,] deleteRowColum = DeleteRowColum(myArray, i, j);
Show2dArray(deleteRowColum);*/