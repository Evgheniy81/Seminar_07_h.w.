/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] CreateArray(int row, int col, int min, int max)
{
    Random rand = new Random();
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
            array[i, j] = rand.Next(min, max + 1);  
    }
    return array;
}

double ArithmeticMeanOflArray(int[,] array)
{
    double arithMean = 0;
    int sum = 0;
    int n = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            n++;
        }
        arithMean = (double)sum / n;
        //return arithMean;
        //arithMean = (double)sum / n;
        

    }
    //return sum;
    return arithMean;


}

void PrintArray(int[,] array)
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
int[,] array = CreateArray(2, 3, 0, 4);
PrintArray(array);
Console.WriteLine();
double arithMean = ArithmeticMeanOflArray(array);
Console.WriteLine($"Среднее арифметическое  {arithMean}");

