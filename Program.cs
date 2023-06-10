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



// int columns = InputNumbers("Введите количество столбцов: ");
// int lines = InputNumbers("Введите количество строк: ");
// int range = InputNumbers("Введите диапозон от 1 до: ");
// int[,] Array = new int[lines, columns];
// CreateArray(Array);
// PrintArray(Array);

// int minSumLine = 0;
// int sumLine = SumLineElements(Array, 0);
// for (int i = 1; i < Array.GetLength(0); i++)
// {
//   int tempSumLine = SumLineElements(Array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }

// Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine} - сумма эллементов) элементов ");

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

// int SumLineElements(int[,] array, int i)
// {
//     int sumLine = array[i, 0];
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         sumLine += array[i, j];
//     }
//     return sumLine;
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




// Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
// int m = InputNumbers("Введите число строк 1-й матрицы: ");
// int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
// int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

// int[,] firstMartrix = new int[m, n];
// CreateArray(firstMartrix);
// Console.WriteLine($"Первая матрица:");
// PrintArray(firstMartrix);

// int[,] secomdMartrix = new int[n, p];
// CreateArray(secomdMartrix);
// Console.WriteLine($"Вторая матрица:");
// PrintArray(secomdMartrix);

// int[,] resultMatrix = new int[m,p];

// MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine($"Произведение первой и второй матриц:");
// PrintArray(resultMatrix);

// void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
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



// Console.WriteLine($"Введите размер массива: ");
// int x = InputNumbers("Введите строки: ");
// int y = InputNumbers("Введите столбцы: ");
// int z = InputNumbers("Введите страницы: ");
// Console.WriteLine($"");

// int[,,] Array = new int[x, y, z];
// CreateArray(Array);
// WriteArray(Array);

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void WriteArray (int[,,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {

//       for (int k = 0; k < array.GetLength(2); k++)
//       {
//         Console.Write( $"{array[i,j,k]}({i},{j},{k}); ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }

// void CreateArray(int[,,] array)
// {
//   int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array.GetLength(0); x++)
//   {
//     for (int y = 0; y < array.GetLength(1); y++)
//     {
//       for (int z = 0; z < array.GetLength(2); z++)
//       {
//         array[x, y, z] = temp[count];
//         count++;
//       }
//     }
//   }
// }