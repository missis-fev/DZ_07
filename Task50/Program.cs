// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 100);
        }
    }
    return array;
}

void findElement(int[,] input)
{
Console.Write("Введите номер строки: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер стобца: ");
int n = int.Parse(Console.ReadLine()!);
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int j = 0; j < input.GetLength(1); j++)
        {
            if (i == m-1 && j == n-1)
            {  
             Console.WriteLine("Заданное число   " + input[i,j]); 
             return;
            }
        }
    }
            Console.WriteLine("Такого числа в массиве нет");             
                 
   }

void PrintArray(int[,] input)
{
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i, j]);

            if (j != input.GetLength(1) - 1)
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}


var array = CreateArray(4, 4);
PrintArray(array);
findElement(array);
