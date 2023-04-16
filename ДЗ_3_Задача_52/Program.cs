/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows,columns, 0, 10);

CalcColumnsAVG(array);

//выводим массив на экран 
Console.WriteLine("Сгенерированные Элементы массива: ");
PrintArray(array);

//Заполнение массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m,n];

    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++){
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

//Вывод массива
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void CalcColumnsAVG(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++){
        double AVG = array[0,j];
        for(int i = 1; i < array.GetLength(0); i++){
            AVG += array[i,j];
        }
        AVG = AVG/array.GetLength(1);
        Console.WriteLine($"Сдреднее арифместическое столбца {j} = {AVG:f1}");
    }    
}