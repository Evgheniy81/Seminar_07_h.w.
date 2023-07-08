/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
/*
int[,] CreateArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rand.Next(-5, 5);
        }
    }
    return array;
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

//Console.Clear();
int[,] array = CreateArray(3, 5);
PrintArray(array);

////
/*
int[,] CreateArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = rand.Next(0, 10);
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    return array;
}
int[,] array = CreateArray(5, 5);
*/
/*
string SearchOfNumber (int [,] array){
    int n = 5;
    int row = array.GetLength(0);
    int col = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (n == array[i,j])
            {
                string (array[i,j]);
            }
            
            else
            {
                Console.WriteLine($"Число {n} не существует в данном массиве");
            }
            //return n;
            //break;
        }
        //return n;
        
    //}
  
*/
//string = Console.WriteLine(SearchOfNumber);


