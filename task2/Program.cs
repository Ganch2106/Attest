// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int AkkFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AkkFunction(m - 1, 1);
    }
    else
    {
        return AkkFunction(m - 1, AkkFunction(m, n - 1));
    }
}
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"{AkkFunction(m, n)} ");
AkkFunction(m,n);
