/*
    Задача 65: Задайте значения M и N. Напишите программу, которая
    выведет все натуральные числа в промежутке от M до N.
    M = 1; N = 5 -> "1, 2, 3, 4, 5"
    M = 4; N = 8 -> "4, 6, 7, 8" 
*/

//Console.Clear();

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

int n = 0, m = 0;

if (numberN == numberM)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write("Warning! Интервал между числами равен нулю!");
    Console.ResetColor();
}
else if (numberN < numberM)
{
    m = numberN;
    n = numberM;
}
else
{
    n = numberN;
    m = numberM;
}

int[] arrayNumber = new int[n - m +1];

arrayNumber = GetArrayNumber(n, m, arrayNumber);

PrintArrayNumber(arrayNumber, numberN, numberM);


int[] GetArrayNumber(int numberN, int numberM, int[] arrayNumber, int i = 0)
{  
    if(numberM <= numberN) 
    {
        arrayNumber[i] = numberM;
        numberM++;
        i++;
        return GetArrayNumber(numberN, numberM, arrayNumber, i);
    }
     return arrayNumber;
}

void PrintArrayNumber(int[] arrayNumber, int numberN, int numberM)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"M = {numberM}; N = {numberN} -> \" ");

    for (int i = 0; i < arrayNumber.Length; i++)
    {
        if (arrayNumber.Length -1 == i) Console.Write($"{arrayNumber[i]} ");
        else Console.Write($"{arrayNumber[i]}, ");
    }

    Console.WriteLine("\"");
    Console.ResetColor();
}