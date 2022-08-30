﻿/*
Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Clear();

double [,] matrix = new double [3,4];

GetRandomMatrix (matrix);


void GetRandomMatrix (double[,] matr)
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

