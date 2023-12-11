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

Console.Write("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m, n];

void CreateArray(int m, int n)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.Next(1, 9);
        }
    }
}

void PrintArray(int[,] array)
{
    int i, j;
    for (i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{ array[i, j]} ");
        }
        Console.WriteLine();
    }
}

CreateArray(m, n);
Console.WriteLine("\nИсходный массив: ");
PrintArray(randomArray);

int SumLine(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

int minSum = 1;
int sum = SumLine(randomArray, 0);
for (int i = 1; i < randomArray.GetLength(0); i++)
{
    if (sum > SumLine(randomArray, i))
    {
        sum = SumLine(randomArray, i);
        minSum = i + 1;
    }
}
Console.WriteLine($"\nСтрока c наименьшей суммой элементов: { minSum}");

