// Задача 56: Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей 
// суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

Task56();
void Task56()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество cтолбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите минимальное значение элемента: ");
    int min = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите максимальное значение элемента: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] result = GetMatrix(rows, columns, min, max);

    PrintMatrix(result, 0);

    int rowMinSum = CountSumRow(result);

    Console.Write($"Номер строки с наименьшей суммой элементов: {rowMinSum + 1} строка");

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

    int CountSumRow(int[,] matrix)
    {
        int minSumRowElements = int.MaxValue;
        int minNumberSumRow = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int sumRowElements = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sumRowElements += matrix[i, j];
            }

            if (sumRowElements < minSumRowElements)
            {
                minSumRowElements = sumRowElements;
                minNumberSumRow = i;
            }
        }
        return minNumberSumRow;
    }
}

