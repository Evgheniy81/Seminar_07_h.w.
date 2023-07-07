/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
double[,] CreateArray(int m, int n)
{
    double[,] array = new double[n, m];
    Random rand = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = Math.Round(rand.Next(-10, 10) * 0.1, 1);
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
double[,] array = CreateArray(5, 5);
PrintArray(array);