// Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.
// Пример
// 4 3 1  (1,2)  => 9
// 2 6 9

Console.Write("Введите размер строки: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер столбца: ");
int Y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер строки: ");
int nX = Convert.ToInt32(Console.ReadLine())-1;
Console.Write("Введите номер столбца: ");
int nY = Convert.ToInt32(Console.ReadLine())-1;

int [,] GetArray(int m, int n, int minN, int maxN)
{
    int [,] array = new int [m,n];
    Random rand = new Random();
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(minN, maxN);
        }
    }
    return array;
}

void PrintArray(int[,] arrPrint)
{
    for (int i=0; i<arrPrint.GetLength(0); i++)
    {
        for (int j=0; j<arrPrint.GetLength(1); j++)
        {
            Console.Write($"{arrPrint[i,j]} ");
        }
        Console.WriteLine();
    }
}

void foundNum(int[,] arr)
{
if (nX<0 || nX>arr.GetLength(0)-1 || nY<0 || nY>arr.GetLength(1)-1)
{
    Console.WriteLine();
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine();
    Console.WriteLine($"Значение элемента массива: {arr[nX,nY]}");
}
}

int[,] newArray = GetArray(Y, X, min, max);
PrintArray(newArray);
foundNum(newArray);