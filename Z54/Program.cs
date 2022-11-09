// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] Puzirek_Strochniy(int[,] mass)
{
    int bubble;
    for(int k =0; k < mass.GetLength(0)*mass.GetLength(1); k++) // мне этот момент не нравится
    {
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 1; j < mass.GetLength(1); j++)
        {
            if(mass[i,j-1]<=mass[i,j])
            {
                bubble = mass[i, j-1];
                mass[i, j-1] = mass[i, j];
                mass[i, j] = bubble;
            }
        }
    }
    }
    return mass;
}

void RandomMatrix(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(1,10);
        }
    }
}

void PrintMatrix(int[,] mass)
{
    Console.WriteLine("Матрица: ");
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write("{0} ", mass[i, j]);
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк матрицы (n): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы (n): ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

RandomMatrix(matrix);
PrintMatrix(matrix);
PrintMatrix(Puzirek_Strochniy(matrix));


