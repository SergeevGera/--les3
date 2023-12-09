// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// 4 3 1  (1,2)  =>  9
// 2 6 9

// Console.Write("Введите номер строки: ");
// int pos1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца: ");
// int pos2 = Convert.ToInt32(Console.ReadLine());
// int n = 5;
// int m = 5;
// Random random = new Random();
// int[,] arr = new int[n, m];
// Console.WriteLine("Исходный массив: ");
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = random.Next(10, 99);
//         Console.Write("{0} ", arr[i, j]);
//     }
//     Console.WriteLine();
// }
// if (pos1 < 0 | pos1 > arr.GetLength(0) | pos2 < 0 | pos2 > arr.GetLength(1) )
// {
//     Console.WriteLine("Элемент не существует  ");
// }
// else
// {
//     Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
// }
// Console.ReadLine();

// Задача 2: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

//  4 3 1   =>   4 6 2
//  2 6 9        2 6 9
//  4 6 2        4 3 1

// int[,] array = new int[4, 4]
// {  { 1, 2, 3, 4 },
//    { 2, 2, 2, 2 },
//    { 1, 1, 1, 1 },
//    { 5, 6, 7, 8 }
// };
// Console.WriteLine();
// for (int i = 0; i < array.GetLength(1); i++)
// {
//     int temp = array[3, i];
//     array[3, i] = array[0, i];
//     array[0, i] = temp;
// }
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }


// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

//  4 3 1   =>   Строка с индексом 0
//  2 6 9
//  4 6 2 

int[,] array = new int[4, 4]
{  { 1, 2, 3, 4 },
   { 2, 2, 2, 2 },
   { 1, 1, 1, 1 },
   { 5, 6, 7, 8 }
};
int max = 0;
for (int i = 0; i < array.GetLength(1); i++)
{
    max = max + array[i];
}