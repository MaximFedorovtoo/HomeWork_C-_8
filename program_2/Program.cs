// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
int FindBiggerLine(int [,] array)
{
    int [] bigger = new int [array.GetLength(0)];
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result = result + array[i,j];
        }
        bigger[i] = result;
        result = 0;
    }
    result = bigger[0];
    for (int i = 1; i < bigger.Length; i++)
    {
        if(bigger[i] < result){result = bigger[i];}
    }
    for (int i = 0; i < bigger.Length; i++)
    {
        if(bigger[i] == result){result = i+1;}
    }
    return result;
}
int[,] AddArray(int [,] array, int column, int line)
{
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
int [,] array = {};
array = AddArray(array,5,4);
PrintArray(array);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {FindBiggerLine(array)} строка");
