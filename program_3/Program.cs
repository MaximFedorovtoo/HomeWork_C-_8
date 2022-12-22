// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4 
// 3 2 | 3 3 
// Результирующая матрица будет:
// 18 20
// 15 18
void PrintMatrix(int [,] matrix_1, int [,] matrix_2)
{
    Console.WriteLine("Даны 2 матрицы:");
    for (int i = 0; i < matrix_1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix_1.GetLength(1); j++)
        {
            if(j == matrix_1.GetLength(1) - 1 )Console.Write($"{matrix_1[i, j]} | ");
            else{Console.Write($"{matrix_1[i, j]} ");}
        }
        for (int j = 0; j < matrix_2.GetLength(1); j++)
        {
            Console.Write($"{matrix_2[i, j]} ");
        }
        Console.WriteLine("");
    }
}
void PrintArray(int [,] array)
{
    Console.WriteLine("Результирующая матрица:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");
    }
}
int [,] ProductMatrices(int [,] matrix_1, int [,] matrix_2)
{
    int [,] result = new int [matrix_1.GetLength(0),matrix_1.GetLength(1)];
   
    for (int i = 0; i < matrix_1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix_1.GetLength(1); j++)
        {
            for (int c = 0; c < matrix_1.GetLength(0); c++)
            {
                result[i,j] = result[i,j]+ matrix_1[i, c] * matrix_2[c, j];
            }
        }
    }
    return result;
}
int [,] matrix_1 = {{2,4},{3,2}};
int [,] matrix_2 = {{3,4},{3,3}};
int [,] result = {};
result = ProductMatrices(matrix_1, matrix_2);
PrintMatrix(matrix_1,matrix_2);
PrintArray(result);

