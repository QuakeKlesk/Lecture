﻿/* // Создание нового двумерного массива

string[,] table = new string[2, 5];

table[1, 2] = "Слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns <5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/

/* // Создание двумерного массива и заполнение его рандомными числами

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);// полуинтервал
        }
    }
}


int [,] matrix = new int[5, 10];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);  */

/* // Метод закрашивания картинки

void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        Pic[row, col] = 1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
}
*/

/* // Создание и печать заданного факториала 


double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 50; i++)
{
//    Console.WriteLine($"{i}! = {Factorial(i)}");
}

*/

/* // Выведение чисел фибоначи

int Fibonachi(int n)
{
    if (n==1 || n==2) return 1;
    else return Fibonachi(n-1) + Fibonachi(n-2);
}
for (int i = 1 ; i < 43; i++)
{
    Console.WriteLine($"{i}! - {Fibonachi(i)}");
}
*/