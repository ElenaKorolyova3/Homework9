// Задача 64: Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число M: ");
string strNumM = Console.ReadLine();
int numM = Convert.ToInt32(strNumM);

Console.Write("Введите число N: ");
string strNumN = Console.ReadLine();
int numN = Convert.ToInt32(strNumN);
Console.Write($"{numN}, ");
Numbers(numM,numN);

void Numbers(int numM, int numN)
{
    if (numM < numN)
    {
        Console.Write($"{numN-1}, ");
        Numbers(numM,numN-1);
    }
}


