Console.Clear();


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


double[,] Matrix(string arrayEntr)
{
    string[] array = arrayEntr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[,] matrixMain = new double[Convert.ToInt32(array[0]), Convert.ToInt32(array[1])];
    return matrixMain;
}

void FillMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(double[,] matrix)
{
    const int cellWidth = 7;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],cellWidth}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ArithmeticMeanColumns(double[,] matrix)
{
    double arithmeticMean = 0;
    double l = Convert.ToDouble(matrix.GetLength(1));
    const int cellWidth = 6;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            arithmeticMean = arithmeticMean + (matrix[i, j] / l);

        }
        Console.Write($"|{arithmeticMean,cellWidth:f1}");
        arithmeticMean = 0;

    }
    Console.Write($"| среднее арифмктическщу колонок");
}


Console.Write("Введите колличество строк и колличество колонок через пробел: ");
double[,] matrixMain = Matrix(Console.ReadLine());


FillMatrix(matrixMain);
PrintMatrix(matrixMain);
ArithmeticMeanColumns(matrixMain);