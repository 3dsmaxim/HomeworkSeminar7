Console.Clear();


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет



void PositionNumber(int[,] matrix, int[] psition)
{
    bool chek = false;


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == psition[0] - 1)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == psition[1] - 1)
                {
                    chek = true;
                    Console.Write($" Число {matrix[i, j]} ");
                }
            }
        }
    }
    Console.Write($"на позиции [{String.Join(", ", psition)}]  {(chek ? "" : "нет чисел чисел")}");
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        const int cellWidth = 6;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {


            Console.Write($"{matrix[i, j],cellWidth}");

        }
        Console.WriteLine();
    }

}

int[,] matrixFyrst = new int[,]
                    {
                        {1, 8, -7, 5, -2},
                        {2, -4, 5, 0, 9},
                        {-1, 7, 10, -3, 4 }
                    }
                    ;

Console.Write("Введите позицию строки: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите позицию колонки: ");
int column = int.Parse(Console.ReadLine());

int[] positionCoordinate = new int[] { row, column };
PrintMatrix(matrixFyrst);
PositionNumber(matrixFyrst, positionCoordinate);