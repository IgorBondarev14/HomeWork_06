// Задана целочисленная квадратная матрица размером N x N. Требуется транспонировать ее 
// относительно главной диагонали.

Console.Write("Введите размер матрицы: ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[N, N];
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        matrix[i, j] = new Random().Next(0,100);
        Console.Write($"{matrix[i, j]}" + "\t");  
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] matrix1 = new int[N, N];
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        matrix1[i, j] = matrix[j, i];
        Console.Write($"{matrix1[i, j]}" + "\t");
    }
    Console.WriteLine();
}
