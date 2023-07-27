// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Task60();
void Task60()
{
    Console.Write("Введите размер массива по оси X: ");
    int sizeX = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите размер массива по оси Y: ");
    int sizeY = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите размер массива по оси Z: ");
    int sizeZ = Convert.ToInt32(Console.ReadLine());

    //Console.Write("Введите минимальное значение элемента: ");
    int min = 10; //Convert.ToInt32(Console.ReadLine());

    //Console.Write("Введите максимальное значение элемента: ");
    int max = 99; //Convert.ToInt32(Console.ReadLine());

    int[,,] result = Get3DMatrix(sizeX, sizeY, sizeZ, min, max);

    PrintMatrix(result);


    int[,,] Get3DMatrix(int x, int y, int z, int min, int max)
    {
        int[,,] matrix = new int[x, y, z];

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                for (int k = 0; k < z; k++)
                {
                    matrix[i, j, k] = new Random().Next(min, max + 1);
                }
            }
        }

        return matrix;
    }

    void PrintMatrix(int[,,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
                }
            }
            Console.WriteLine();
        }
    }
}
