// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j]< 10){Console.Write($"0{array[i, j]} ");}
            else{Console.Write($"{array[i, j]} ");}
        }
        Console.WriteLine("");
    }
}
int [,] AddArrayRound(int [,] array)
{
    
   
    int n = array.GetLength(0);

    int i = 0, j = 0;

    int value = 1;

    while (n != 0)
    {
        int k = 0;
        do { array[i, j++] = value++; } 
        while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j; 
        n = n < 2 ? 0 : n - 2;
    }
    return array;
    
    
}

int [,] array = new int [4,4];
array = AddArrayRound(array);
PrintArray(array);