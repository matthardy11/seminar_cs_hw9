// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AkkermanFunc(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  else if (n == 0)
  {
    return AkkermanFunc(m - 1, 1);
  }
  else 
  {
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
  }
}

int m = 3;
int n = 2;

System.Console.WriteLine(AkkermanFunc(m, n));