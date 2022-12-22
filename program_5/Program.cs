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
int [,] AddNumbRound(int [,] array)
{
    int [ ] numbers = new int [array.GetLength(0)*array.GetLength(1)];
    int tmp = 1;
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = tmp;
        tmp++;
    }
    int count_1 = 0;
    int count_2 = array.GetLength(1);
    int count_3 = array.GetLength(0)+array.GetLength(1)+1;
    int count_4 = array.GetLength(0)+array.GetLength(1)+array.GetLength(1)-1;
    int count_5 = array.GetLength(0)+array.GetLength(1)+array.GetLength(1);
    int count_6 = array.GetLength(0)+array.GetLength(1)+array.GetLength(1)+array.GetLength(1)-1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == 0){array[i,j] = numbers[count_1];}
            if(j == array.GetLength(1)-1 & i != 0){array[i,j] = numbers[count_2]; count_2++;}
            if(i == array.GetLength(0)-1 & j != array.GetLength(1)-1 & i != 0){array[i,j] = numbers[count_3]; count_3--;}
            if(j == 0 & i != array.GetLength(0)-1 & j != array.GetLength(1)-1 & i != 0){array[i,j] = numbers[count_4]; count_4--;}
            if(i == 1 & j != 0 & i != array.GetLength(0)-1 & j != array.GetLength(1)-1 & i != 0){array[i,j] = numbers[count_5]; count_5++;}
            if(i == 2 & i != 1 & j != 0 & i != array.GetLength(0)-1 & j != array.GetLength(1)-1 & i != 0){array[i,j] = numbers[count_6]; count_6--;}
            count_1++;
        }
        
    }
    return array;
}

int [,] array = new int [4,4];
array = AddNumbRound(array);
PrintArray(array);