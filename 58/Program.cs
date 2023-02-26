//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.Clear();

int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы = строк 2-й матрицы: ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
Console.WriteLine();

int[,] MartrixA = new int[m, n];
CreateArray(MartrixA);
Console.WriteLine("Первая матрица:");
WriteArray(MartrixA);
Console.WriteLine();

int[,] MartrixB = new int[n, p];
CreateArray(MartrixB);
Console.WriteLine("Вторая матрица:");
WriteArray(MartrixB);
Console.WriteLine();

int[,] MatrixC = new int[m,p];

MultiplyMatrix(MartrixA, MartrixB, MatrixC);
Console.WriteLine("Произведение первой и второй матриц:");
WriteArray(MatrixC);

void MultiplyMatrix(int[,] MartrixA, int[,] MartrixB, int[,] MatrixC)
{
  for (int i = 0; i < MatrixC.GetLength(0); i++)
  {
    for (int j = 0; j < MatrixC.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < MartrixA.GetLength(1); k++)
      {
        sum += MartrixA[i,k] * MartrixB[k,j];
      }
      MatrixC[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
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
