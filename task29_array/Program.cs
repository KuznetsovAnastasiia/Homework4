﻿/*Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

void FillArray(int[] arr) // метод заполнения массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,100);
    }
}

void PrintArray(int[] arr) // метод вывода массива
{
    Console.Write("["); // специально на печать "[" перед массивом, чтобы массив вывелся на консоль, как в примере
    for (int i = 0; i < arr.Length - 1; i++) // специально без последного (восьмого) элемента массива
    {
        Console.Write(arr[i] + ", ");
        if (i == arr.Length - 2) // специально для вывода последного (восьмого) элемента массива
        {
            Console.Write(arr[arr.Length - 1] + "]"); // специально на печать "]" после массива
        }
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);