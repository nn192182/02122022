//Задайте двумерный массив размеров m*n , заполненный случайными целыми числами.
/*
int [,] Create2dArray (int row, int column , int minVal, int maxVal)
{
    int [,] created2dArray = new int [row, column];

    for (int i = 0; i < row; i ++)
         for (int j = 0; j < column; j ++)
              created2dArray [i,j] = new Random().Next(minVal , maxVal + 1);
    return created2dArray;
}
void Show2dArray(int[,] array)
{
    for(int i =0; i  < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i,j] + " ");// вывод значений
        }
        Console.WriteLine(); //переход на новую строку
    }
        Console.WriteLine(); // отступ от массива
}

Console.Write ("Input count of rows : ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input count of columns : ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input min possible Value : ");
int min  = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input max possible Value : ");
int max  = Convert.ToInt32(Console.ReadLine());

int [,] newArray = Create2dArray (rows, columns, min, max);
Show2dArray(newArray);


*/
// Найти сумму элементов главной диагонали


/*
int[,] create2dArray = (int row, int column, int minVal, int maxVal)
{
    int[,] create2dArray = new int [row, column];

    for (int i = 0; i < row; i ++)
        for (int j = 0; j< column; j++)
             created2dArray [i,j] = new Random ().Next(minVal,maxVal +1);
return created2dArray; 
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLenght(0); j++)
        {
            Console.Write(array[i,j] + " "); // вывод значений
        }
        Console.WriteLine(); //переход на новую строку
    }
    Console.WriteLine(); //отступ от массива
}

int SumNumber(int [,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (i ==j)
            {
                  sum = sum + array[i, j];
            }
        }
    }
    return sum;
}

int[,] newArray = Create2dArray(3, 4, 5, 10);
Show2dArray(NewArray);

int sum = SumNumber (NewArray);
Console.WriteLine($" The sum of element within the main is {sum}";


/*

Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9

*/
/*
double [,] Create2dArray (int row, int column , int minVal, int maxVal)
{
    double [,] created2dArray = new double [row, column];

    for (int i = 0; i < row; i ++)
         for (int j = 0; j < column; j ++)
              created2dArray [i,j] = new Random().Next(minVal , maxVal + 1);
    return created2dArray;
}
void Show2dArray(double[,] array)
{
    for(int i =0; i  < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i,j] + " ");
        }
        Console.WriteLine(); 
    }
        Console.WriteLine();
}

Console.Write ("Input count of rows : ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input count of columns : ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input min possible Value : ");
int min  = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input max possible Value : ");
int max  = Convert.ToInt32(Console.ReadLine());

double [,] newArray = Create2dArray (rows, columns, min, max);

Show2dArray(newArray);
*/
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет

*/
/*
Void [,] Create2dArray (int row, int column , int minVal, int maxVal)
{
   int [,] created2dArray = int [row, column];

    for (int j = 0; j < GetLenght(1); j ++)
    
        int summ = 0;
    {
         for (int  i = 0; j < GetLenght(0); i ++)
             
    }
         created2dArray [i,j] = new Random().Next(minVal , maxVal + 1);
    return created2dArray;
}

Console.Write ("Input count of rows : ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input count of columns : ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input min possible Value : ");
int min  = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input max possible Value : ");
int max  = Convert.ToInt32(Console.ReadLine());

int [,] newArray = Create2dArray (rows, columns, min, max);

Show2dArray(newArray);


Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
int Middle (int[,]array)
{
    int sum1 =0; int sum2 = 0; int sum3 = 0; int sum4 = 0;
    for (int j = 0 ; j < array.GetLenght(1); j++)
        (int i = 0 ; i < array.GetLenght(0); i++)
       {
        if(j == 0) sum1 =+ array[i,j];
        else if (i == 1) sum2 =+ array[i,j]
        else if (i == 2) sum3 =+ array[i,j]
         else if (i == 3) sum4 =+ array[i,j]
       }  
       return sum1
}

Console.Write ("Input sum1 : ");
int sum1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input sum2 : ");
int sum2 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input sum3 : ");
int sum3  = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input sum4 : ");
int sum4  = Convert.ToInt32(Console.ReadLine());

int [,] Middle = Show2dArray (sum1, sum2, sum3, sum4);

Show2dArray(newArray);
*/