// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//Решение простое: спиральный вывод - это 2 по 2 зеркальных, относительно центра, треугольника
// + = = = +
// + + = + +
// + + 0 + +
// + + = + +
// + = = = +



// Метод расположения цифр по спирали

int[,] Spiral(int[,] matrix)
{
    int ind = 0;
    int m = 0;
    int i, j; // j - добавлена для удобства распознавания горизонтальных(=) треугольников
    while (m < matrix.GetLength(0) / 2)
    {
        for (i = m; i < matrix.GetLength(0) - m; i++)
        {
            ind++;
            matrix[i, m] = ind;
        }
        for (j = m + 1; j < matrix.GetLength(1) - (m + 1); j++)
        {
            ind++;
            matrix[matrix.GetLength(1) - (m + 1), j] = ind;
        }
        for (i = m; i < matrix.GetLength(0) - m; i++)
        {
            ind++;
            matrix[matrix.GetLength(0) - 1 - i, matrix.GetLength(0) - (m + 1)] = ind;
        }
        for (j = m + 1; j < matrix.GetLength(1) - (m + 1); j++)
        {
            ind++;
            matrix[m, matrix.GetLength(1) - 1 - j] = ind;
        }
        m++;
    }
    if (matrix.GetLength(0) % 2 != 0)
    {
        ind++;
        matrix[matrix.GetLength(0) - ((matrix.GetLength(0) / 2) + 1), matrix.GetLength(1) - ((matrix.GetLength(1) / 2) + 1)] = ind;
    }
    return matrix;
}

// Метод вывода матрицы

void PrintMatrix(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write("{0,6:F1} ", mat[i, j]);
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите длину квадратной матрицы (n): ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] mass = new int[n, n];

PrintMatrix(Spiral(mass));
