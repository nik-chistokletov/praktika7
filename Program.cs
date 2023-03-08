﻿// 47. Показать двумерный массив размером m×n заполненный вещественными числами

// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9

//Console.Write("Введите m: ");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите n: ");
//int n = Convert.ToInt32(Console.ReadLine());

//Console.Clear();
//Console.WriteLine($"m = {m}, n = {n}.");

//double[,] array = new double[m, n];

//CreateArrayDouble(array);

//WriteArray(array);

//Console.WriteLine();

//void CreateArrayDouble(double[,] array)
//{
  //for (int i = 0; i < m; i++)
  //{
    //for (int j = 0; j < n; j++)
    //{
      //array[i, j] = new Random().NextDouble() * 20 - 10;
    //}
  //}
//}

//void WriteArray (double[,] array)
//{
//for (int i = 0; i < m; i++)
  //{
    //  for (int j = 0; j < n; j++)
     // {
      //  double alignNumber = Math.Round(array[i, j], 1);
      //  Console.Write(alignNumber + " ");
      //}
      //Console.WriteLine();
  //}
//}


//CreateArrayDouble(array);
//WriteArray(array);
// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


//int rows = ReadInt("Введите индекс строки: ");
//int colums = ReadInt("Введите индекс столбца: ");
//int[,] numbers = new int[4, 3];
//FillArray2D(numbers);
//PrintArray2D(numbers);

//if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
//else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");


// Заполнение массива рандомными числами от 1 до 9
//void FillArray2D(int[,] array)
//{
  //  for (int i = 0; i < array.GetLength(0); i++)
  //  {
    //    for (int j = 0; j < array.GetLength(1); j++)
    //    {
    //        array[i, j] = new Random().Next(1, 10);
     //   }
   // }
//}

//  Функция вывода массива в терминал
//void PrintArray2D(int[,] array)
//{
  //  for (int i = 0; i < array.GetLength(0); i++)
  //  {
    //    for (int j = 0; j < array.GetLength(1); j++)
    //    {
    //        Console.Write(array[i, j] + " ");
    //    }
    //    Console.WriteLine();
   // }
   // Console.WriteLine();
//}

// Функция ввода 
//int ReadInt(string message)
//{
  //  Console.Write(message);
  //  return Convert.ToInt32(Console.ReadLine());
//}

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Random random = new Random();

int[,] arr = new int[3,4];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("    ");
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ sum / arr.GetLength(0)} ");
}
Console.ReadLine();