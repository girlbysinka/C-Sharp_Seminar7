/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента или же указание, 
 что такого элемента нет.(на вход именно поступает позиция элемента, 
 можете разбить на две переменные или прописать в одну строку и 
 конвертировать в два числа, комментарии в конце семинара по этой задаче)
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/
Console.Clear();

double [,] matrix = new double [3,4];

GetRandomMatrix (matrix);

int userString = new int();
Console.WriteLine("Введите номер строки:");
userString = Convert.ToInt32(Console.ReadLine());
    
int userColumn = new int();
Console.WriteLine("Введите номер столбца:");
userColumn = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if (userString < matrix.GetLength(0) && userColumn < matrix.GetLength(1))
    {
        Console.WriteLine($"Значение элемента равно {matrix[userString, userColumn]} ");
    }
else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }


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
