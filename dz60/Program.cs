/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
int NumberToAbsInt (string message)
{
    System.Console.WriteLine(message);
    string str = System.Console.ReadLine() ?? String.Empty;
    double resultDouble = Math.Abs(Convert.ToDouble(str));
    int resultInt = (int) resultDouble;
    System.Console.WriteLine($"The entered value is reduced to: {resultInt}");
    return resultInt;
}
int [,,] CreatingThreeMatrix (int valueRow, int valueColl, int valueList)
{
  int [,,] newThreeMatrix = new int [valueRow, valueColl, valueList];
  int sizeArrayExclusive = valueRow*valueColl*valueList;
  int firstValueRandom = 0;
  int lastValueRandom = 20;
  int numberGeneretionRange = lastValueRandom - firstValueRandom;
  if (sizeArrayExclusive >= numberGeneretionRange)
  {
    System.Console.WriteLine("Error!The number of array elements exceeds the size of the random number range!");
    return newThreeMatrix;
  }
  Random rnd = new Random();
  bool checkingMatch=false;
  int tempRandom = 0;
  for (int i = 0; i < valueRow; i++)
  {
    for (int j = 0; j < valueColl; j++)
    {
      for (int k = 0; k < valueList;)
      {
        tempRandom = rnd.Next(firstValueRandom,lastValueRandom);
        checkingMatch = false;
        for (int l = 0; l < i+1;)
        {
          for (int m = 0; m < valueColl;)
          {
            for (int n = 0; n < valueList;)
            {
              if (newThreeMatrix [l,m,n] == tempRandom)
              {
                checkingMatch = true;
                break;
              }
              n++;
            }
            if (checkingMatch)
            break;
            m++;
          }
          if (checkingMatch)
          break;
          l++;
        }
        if (!checkingMatch)
        {
          newThreeMatrix[i,j,k] = tempRandom;
          k++;
        }
      } 
    }  
  }
  return newThreeMatrix;
}
void ShowThreeMatrix (int [,,] threeMatrixIn)
{
  for (int i = 0; i < threeMatrixIn.GetLength(0); i++)
  {
      for (int j = 0; j < threeMatrixIn.GetLength(1); j++)
      {
        for (int k = 0; k < threeMatrixIn.GetLength(2); k++)
        {
          System.Console.Write($"{threeMatrixIn[i,j,k]}({i},{j},{k})\t");
        }
        System.Console.WriteLine();
      }
      System.Console.WriteLine();
  }
}
int useRowNumberMultiArray = NumberToAbsInt("Enter the number of rows of the three-dimensional array");
int useColumnNumberMultiArray = NumberToAbsInt("Enter the number of columns of the three-dimensional array");
int useListNumberMultiArray = NumberToAbsInt("Enter the number of lists of the three-dimensional array");
int [,,] useCreatingThreeMatrix = CreatingThreeMatrix (
                                                        valueRow:useRowNumberMultiArray,
                                                        valueColl:useColumnNumberMultiArray,
                                                        valueList:useListNumberMultiArray
                                                                                              );
System.Console.WriteLine("Your matrix filled with random exceptional numbers ranging from 0 to 20:");
ShowThreeMatrix(useCreatingThreeMatrix);