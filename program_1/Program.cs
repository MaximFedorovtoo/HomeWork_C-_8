// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
void PrintArray(int [,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");
    }
}
int[,] EditArray(int [,]array)
{
    Console.WriteLine("Получается такой массив:");
    int tmp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int b = 0; b < array.GetLength(0)*array.GetLength(1); b++)
        {
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                if(array[i,j] < array[i,j+1])
                {
                    tmp = array[i,j];
                    array[i,j] = array[i,j+1];
                    array[i,j+1] = tmp;
                }
            }    
        }
        
    }
    return array;
}
int[,] AddArray(int [,] array, int column, int line)
{
    Console.WriteLine("Задан массив:");
    array = new int [column,line];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
        
    }
    return array;
}
int RandNumber(int numb)
{
    numb = new Random().Next(4,9);
    return numb;
}
int line = 0;
line = RandNumber(line);
int column = 0;
column = RandNumber(column);
int [,] array = {};
array = AddArray(array,column,line);
PrintArray(array);
Console.WriteLine("");
array = EditArray(array);
PrintArray(array);

