// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите два числа:");
Console.Write("Введите число M: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int SumNaturalElements(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumNaturalElements(m, n);
        return res;
    }
}

int result = SumNaturalElements(m1, n1);
Console.WriteLine(result + m1);
