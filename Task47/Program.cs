// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


float[,] CreateArray(int rows, int columns)
{
    var random = new Random();

    float[,] array = new float[rows, columns];

    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.NextSingle();
        }
    }

    return array;
}

void Print2DArray(float[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i, j]);

            if (j != input.GetLength(1) - 1)
                Console.Write(",   ");
        }
        Console.WriteLine();
    }
}


var array = CreateArray(3, 4);
Console.WriteLine("Двумерный массив размером mxn, заполненный случайными вещественными числами:");
Print2DArray(array);
