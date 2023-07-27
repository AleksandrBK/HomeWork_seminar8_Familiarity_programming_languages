// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Task58();
void Task58()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Введите количество cтолбцов: {rows}");
    int columns = rows;

    Console.Write("Введите минимальное значение элемента: ");
    int min = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите максимальное значение элемента: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] firstMatrix = GetMatrix(rows, columns, min, max);
    int[,] secondMatrix = GetMatrix(rows, columns, min, max);
    
    Console.WriteLine("Даны две матрицы:");
    MultiplyMatrix(firstMatrix, secondMatrix, 0);


    int[,] GetMatrix(int m, int n, int min, int max)
    {
        int[,] matrix = new int[m, n];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(min, max + 1);
            }
        }
        return matrix;
    }

    // void PrintMatrix(int[,] matrix, int decimalPlaces)
    // {
    //     for (int i = 0; i < matrix.GetLength(0); i++)
    //     {
    //         for (int j = 0; j < matrix.GetLength(1); j++)
    //         {
    //             string formattedNumber = matrix[i, j].ToString($"F{decimalPlaces}");
    //             Console.Write(formattedNumber.PadRight(5));
    //         }
    //         Console.WriteLine();
    //     }
    // }


    void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int decimalPlaces)
    {
        int rows = firstMatrix.GetLength(0);
        int columns = firstMatrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                string formattedNumber = firstMatrix[i, j].ToString().PadRight(2);
                Console.Write(formattedNumber + " ");
            }
            Console.Write(" |   ");
            for (int j = 0; j < columns; j++)
            {
                string formattedNumber = secondMatrix[i, j].ToString().PadRight(2);
                Console.Write(formattedNumber + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Произведение матриц равно:");

        int[,] resultMatrix = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int sum = 0;
                for (int k = 0; k < columns; k++)
                {
                    sum += firstMatrix[i, k] * secondMatrix[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                string formattedNumber = resultMatrix[i, j].ToString().PadRight(3);
                Console.Write(formattedNumber + " ");
            }
            Console.WriteLine();
        }
    }
}

