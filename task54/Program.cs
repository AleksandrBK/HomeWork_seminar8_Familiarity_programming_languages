// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Task54();
void Task54()
{
    Console.WriteLine("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите количество cтолбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите минимальное значение элемента: ");
    int min = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите максимальное значение элемента: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] result = GetMatrix(rows, columns, min, max);

    PrintMatrix(result, 0);
    Console.WriteLine("Отсортированный массив чисел:");
    SortMatrix(result, 0);


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

    void PrintMatrix(int[,] matrix, int decimalPlaces)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                string formattedNumber = matrix[i, j].ToString($"F{decimalPlaces}");
                Console.Write(formattedNumber.PadRight(5));
            }
            Console.WriteLine();
        }
    }


    void SortMatrix(int[,] matrix, int decimalPlaces)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
                {
                    if (matrix[i, k] < matrix[i, k + 1])
                    {
                        int temp = matrix[i, k];
                        matrix[i, k] = matrix[i, k + 1];
                        matrix[i, k + 1] = temp;
                    }
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                string formattedNumber = matrix[i, j].ToString($"F{decimalPlaces}");
                Console.Write(formattedNumber.PadRight(5));
            }
            Console.WriteLine();
        }
    }
}

