﻿// Задача 54: Задайте двумерный массив. Напишите программу,
//             которая упорядочит по убыванию элементы каждой строки двумерного массива.

using System;
using static System.Console;

Clear();


Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

int[,] numbers = new int[rows, columns];
FillArrayRandomNumbers(numbers);
WriteLine();
WriteLine("Массив до изменения");
PrintArray(numbers);
            
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < numbers.GetLength(1) - 1; z++)
            {
                if (numbers[i, z] < numbers[i, z + 1]) 
                {
                     int temp = 0;
                    temp = numbers[i, z];
                    numbers[i, z] = numbers[i, z + 1];
                    numbers[i, z + 1] = temp;
                }
            }
        }
    }
        WriteLine();
        WriteLine("Массив с упорядоченными значениями");
        PrintArray(numbers);
            
    void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(0, 10);
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                    Write(array[i, j] + " ");
            }
                    WriteLine("");
        }
    }