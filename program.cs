// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите начальное целое число M нижнего дипазона значений: ");
int M = Convert.ToInt32(Console.ReadLine());

if (M < 1) M = 1;

Console.Write("Введите конечное целое число N верхнего дипазона значений: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 1)
{
    Console.Write("В заданном Вами диапазоне отсутствуют натуральные числа");
}
else
{

    SumFromMToN(M, N);

    // вызов функции "сумма чисел от M до N"
    void SumFromMToN(int m, int n)
    {
        Console.Write("Сумма натуральных чисел в заданном диапазоне: " + SumMN(M - 1, N));
    }

    // функция сумма чисел от M до N
    int SumMN(int M, int N)
    {
        int result = M;
        if (M == N)
            return 0;
        else
        {
            M++;
            result = M + SumMN(M, N);
            return result;
        }
    }
}
