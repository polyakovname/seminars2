// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю
// строку массива.
// Пример
// 4 3 1    4 6 2
// 2 6 9 => 2 6 9
// 4 6 2    4 3 1

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] array = new int[m,n];
    Random rand = new Random();
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<m; j++)
        {
            array[i,j] = rand.Next(min,max);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void ChangedArray(int[,] arr)
{
    int iMax = arr.GetLength(0);
    int jMax = arr.GetLength(1);

    for (int i=0; i<iMax; i++)
    {
        for (int j=0; j<jMax; j++)
        {
            int a = arr[0, j];
            arr[0, j] = arr[4, j];
            arr[4, j] = a; 
        }
    }
}

int[,] newArray = GetArray(5, 5, 1, 9);
PrintArray(newArray);
ChangedArray(newArray);
Console.WriteLine();
PrintArray(newArray);