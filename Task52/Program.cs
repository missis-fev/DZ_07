// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] input)
{
    for (int i = 0; i < input.GetLength(0); i++)
    {

        for (int j = 0; j < input.GetLength(1); j++)
        {

            Console.Write(input[i, j]);

            if (j != input.GetLength(1) - 1)
                Console.Write(" | ");
        }
        Console.WriteLine();
    }
}
void sumSr(int[,] input)
{
    var m = 0;
    double[] array = new double[input.GetLength(1)];
    for (int j = 0; j < input.GetLength(1); j++)

    {
        for (int i = 0; i < input.GetLength(0); i++)
        {
            array[m] = array[m] + input[i, j];
            
        }
        array[m] = Math.Round(array[m] / (input.GetLength(0)), 2);
        m++;
         
    }
    Console.WriteLine(string.Join(" | ", array));


}
var array = CreateArray(3, 4);
Print2DArray(array);
Console.WriteLine("");
sumSr(array);
