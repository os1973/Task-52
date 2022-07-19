/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] matrix = new int[N, M];
Random randomizer = new Random();

for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            matrix[i, j] = rand.Next(0, 10);    
        }
    }

Console.WriteLine("Матрица");
for (int i = 0; i < N; i++)
    {
    for (int j = 0; j < M; j++)
        {
            Console.Write(matrix[i, j]);
            summ[i] += matrix[j, i];      
        } 
        Console.WriteLine();
    }

Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число M:");
int M = int.Parse(Console.ReadLine()); 

int[] summ = new int[M];

Console.WriteLine();
foreach (double elem in summ)
{
    Console.Write(elem/M); 
}
