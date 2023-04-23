// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
string strNumM = Console.ReadLine();
int numM = Convert.ToInt32(strNumM);

Console.Write("Введите число N, которое будет больше, чем число M: ");
string strNumN = Console.ReadLine();
int numN = Convert.ToInt32(strNumN);
SumNumber(numM,numN);

int SumNumber(int numM, int numN)
{
 int sum = 0;
 for (int i = numM; i <= numN; i++) 
 sum=sum + i;
 
 return sum;
}

Console.WriteLine($"Сумма чисел в диапозоне между {numM} и {numN} равны {SumNumber(numM,numN)}");