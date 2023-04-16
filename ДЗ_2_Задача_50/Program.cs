/*
Задача 50. Напишите программу, которая на вход принимает два числа(строка, столбец), проверяя есть ли такая позиция в двумерном массиве и возвращает сообщение о том, что оно найдено, а также какое число стоит на этом месте или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

i = 1, j = 3 -> Такой элемент есть: 3
i = 4, j = 2 -> такого элемента в массиве нет
*/

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows,columns, 0, 10);

//запрос ввода координат искомого элемента
Console.WriteLine("Введите координаты искомого элемента в массиве: ");
Console.Write("Введите N строки: ");
int RowNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите N Столбца: ");
int ColumnNumber = int.Parse(Console.ReadLine()!);
//ищем элемент
SearchElement(array, RowNumber, ColumnNumber);
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

//Поиск и вывод искомого элемента в массиве
void SearchElement(int[,] array, int RowNumber, int ColumnNumber)
{
    int i = array.GetLength(0);
    //Console.WriteLine($"i = {i}"); //вывод значения для теста
    int j = array.GetLength(1);
    //Console.WriteLine($"j = {j}"); //вывод значения для теста
    if(RowNumber<=i && ColumnNumber<=j)
    {
        Console.WriteLine($"i={RowNumber}, j={ColumnNumber} -> Данный элемент есть в массиве со значением: {array[RowNumber,ColumnNumber]}");
    }
    else
    {
        Console.WriteLine($"i={RowNumber}, j={ColumnNumber} -> Данный элемент отсутствует в массиве.");
    }    
}