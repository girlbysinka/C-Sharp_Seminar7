/*Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();

int [,] matrix = new int [3,4];

GetRandomMatrix (matrix);

Console.WriteLine();

int j = 0;
    
while (j < matrix.GetLength(1))
    {
        double sum = 0;
        double arithmeticmean = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = sum + matrix[i, j];
            }   
        arithmeticmean = Math.Round(sum / matrix.GetLength(0), 1);
        Console.Write($"{arithmeticmean} ");
        j++;
    }
     


void GetRandomMatrix (int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                    {
                    matr[i, j] = new Random().Next(-10,10);
                    Console.Write($"{matr[i, j]} ");
                    }
                Console.WriteLine();
            }
    } 