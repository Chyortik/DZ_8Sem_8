/*Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

Console.Clear();
Console.WriteLine($"Сразу задаем матрицы, которые можно перемножить, т.е. количество столбцов первой матрицы равно количеству строк второй матрицы");
Console.WriteLine($"Введите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите количество строк 1-й матрицы: ");
int n = InputNumbers("Введите количество столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите количество столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 0 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMartrix);

int[,] secondMartrix = new int[n, p];
CreateArray(secondMartrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(secondMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"Произведение матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine()!);
  return output;
}

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

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}