/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая
будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
суммой элементов: 1 строка */
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
int MinSummElementsRow (int [,] matrixForSearchMinRow)
{
    int Sum;
    int temp = 0;
    int stringMinSum = 0;
    for (int i = 0; i < matrixForSearchMinRow.GetLength(0); i++)
    {
        Sum = 0;
        for (int j = 0; j < matrixForSearchMinRow.GetLength(1); j++)
        {
            Sum += matrixForSearchMinRow[i,j];
        }
        if (i == 0)
        {
            temp = Sum;
            stringMinSum = i;
        }
        else if (temp > Sum)
        {
            temp = Sum;
            stringMinSum = i;
        }
        System.Console.WriteLine($"Sum row №: {i} = {Sum}");
    }
    System.Console.WriteLine();
    return stringMinSum;
}
void ShowMatrixWithMinSumRow (int [,] matrixIn, int rowMin)
{
    for (int i = 0; i < matrixIn.GetLength(0); i++)
    {
        for (int j = 0; j < matrixIn.GetLength(1); j++)
            {

                if (i == rowMin)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.Write($"{matrixIn[i,j]}\t");
                    Console.ResetColor();
                }
                else
                System.Console.Write($"{matrixIn[i,j]}\t");
            }
            System.Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"stringMinSum = {rowMin}");
    Console.ResetColor();
}
int useRowsNumber = NumberToAbsInt("Enter the number of rows of the matrix: ");
int useColumnsNumber = NumberToAbsInt("Enter the number of columns of the matrix: ");
int [,] useMatrix = CreatingMatrix(useRowsNumber, useColumnsNumber);
ShowMatrix(useMatrix);
System.Console.WriteLine();
ShowMatrixWithMinSumRow(useMatrix, MinSummElementsRow(useMatrix));