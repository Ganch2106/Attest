// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int[] mas = { 1, 2, 5, 0, 10, 34 };

void PrintMasBack(int[] mas, int i = 0)
{
    if (i > mas.Length - 1)
    {
        return;
    }
    PrintMasBack(mas, i + 1);
    Console.Write($"{mas[i]} ");
}
PrintMasBack(mas);








