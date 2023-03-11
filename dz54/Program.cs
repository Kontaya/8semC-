/* Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int NumberToAbsInt (string message)
{
    System.Console.WriteLine(message);
    string str = System.Console.ReadLine() ?? String.Empty;
    double resultDouble = Math.Abs(Convert.ToDouble(str));
    int resultInt = (int) resultDouble;
    System.Console.WriteLine($"The entered value is reduced to: {resultInt}");
    return resultInt;
}

int [,] CreatingMatrix (int valueRow, int valueColl)
{
    int [,] newMatrix = new int [valueRow, valueColl];
    Random rnd = new Random();
    for (int i = 0; i < valueRow; i++)
    {
        for (int j = 0; j < valueColl; j++)
        {
            newMatrix[i,j] = rnd.Next(0,10);
        }
    }
    return newMatrix;
}

void ShowMatrix (int [,] matrixIn)
{
    for (int i = 0; i < matrixIn.GetLength(0); i++)
    {
        for (int j = 0; j < matrixIn.GetLength(1); j++)
            {
                System.Console.Write($"{matrixIn[i,j]}\t");
            }
            System.Console.WriteLine();
    }
}

int [,]  MatrixAskendingRows (int [,] matrixForIncreasing)
{
    int temp = 0;
    for (int i = 0; i < matrixForIncreasing.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForIncreasing.GetLength(1); j++)
        {
            for (int k = 0; k < matrixForIncreasing.GetLength(1); k++)
            {
                if (matrixForIncreasing[i,j]>matrixForIncreasing[i,k])
                { 
                    temp = matrixForIncreasing[i,j];
                    matrixForIncreasing[i,j] = matrixForIncreasing[i,k];
                    matrixForIncreasing[i,k] = temp;
                }
            }
        }
    }
    return matrixForIncreasing;
}

int useRowsNumber = NumberToAbsInt("Enter the number of rows of the matrix: ");
int useColumnsNumber = NumberToAbsInt("Enter the number of columns of the matrix: ");
int [,] useMatrix = CreatingMatrix(useRowsNumber, useColumnsNumber);
ShowMatrix (useMatrix);
System.Console.WriteLine();
ShowMatrix (MatrixAskendingRows(useMatrix));