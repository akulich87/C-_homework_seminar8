// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [rows,columns];

for (int i = 0; i < array.GetLength(0); i++)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
    array[i,j] = new Random().Next(0,10);
    Console.Write(array[i,j] + " ");
  }
  Console.WriteLine();
}

Console.WriteLine();
