// int columns = InputNumbers("Введите количество столбцов: ");
// int lines = InputNumbers("Введите количество строк: ");
// int range = InputNumbers("Введите диапозон от 1 до: ");
// int[,] Array = new int[lines, columns];
// CreateArray(Array);
// PrintArray(Array);
// Console.WriteLine();
// SortArray(Array);
// PrintArray(Array);

// void SortArray(int[,] array)
// {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1) - 1; j++)
//             {
//                 for (int k = j; k < array.GetLength(1); k++)
//                 {
//                     if (array[i, j] < array[i, k])
//                     {
//                         int temp = array[i, j];
//                         array[i, j] = array[i, k];
//                         array[i, k] = temp;
//                     }
//                 }
//             }
//         }
// }

// void CreateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(range);
//         }
//     }
// }

// int InputNumbers(string input)
// {
//     Console.WriteLine(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }



int columns = InputNumbers("Введите количество столбцов: ");
int lines = InputNumbers("Введите количество строк: ");
int range = InputNumbers("Введите диапозон от 1 до: ");
int[,] Array = new int[lines, columns];
CreateArray(Array);
PrintArray(Array);

int minSumLine = 0;
int sumLine = SumLineElements(Array, 0);
for (int i = 1; i < Array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(Array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine} - сумма эллементов) элементов ");

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

int InputNumbers(string input)
{
    Console.WriteLine(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}