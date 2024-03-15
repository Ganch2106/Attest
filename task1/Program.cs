// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.


void GetListNatNums(int n, int m)
{
    if (m == n )
    {
        Console.Write($"{m} ") ;
        return; 
    }
    Console.Write($"{m} ");
    GetListNatNums(n,m + 1);
}

Console.Write("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

GetListNatNums(n,m);