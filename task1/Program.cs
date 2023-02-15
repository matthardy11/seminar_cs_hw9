// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int M = 1;
int N = 15;

int SumNumberInRange(int startRange, int finishRange)
{
  if (startRange < finishRange)
  {
    startRange += SumNumberInRange(startRange+1, finishRange);
    return startRange; 
  }
  return startRange;
}

System.Console.WriteLine($"Сумма чисел от {M} до {N} равна {SumNumberInRange(M, N)}");