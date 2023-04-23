// Задача 68: Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите положительное число M: ");
string strNumM = Console.ReadLine();
int numM = Convert.ToInt32(strNumM);

Console.Write("Введите положительное число N: ");
string strNumN = Console.ReadLine();
int numN = Convert.ToInt32(strNumN);

int AkkerackermanFunct(int numM, int numN)
{
if (numM == 0) return numN + 1;
else if (numN == 0) return AkkerackermanFunct(numM - 1, 1);
else return AkkerackermanFunct(numM - 1, AkkerackermanFunct(numM, numN - 1));
}

Console.Write($"Функция Аккермана равна {AkkerackermanFunct(numM, numN)} ");