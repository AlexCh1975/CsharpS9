/*
    Задача 63: Задайте значение N. Напишите программу, которая выведет
    все натуральные числа в промежутке от 1 до N.
    N = 5 -> "1, 2, 3, 4, 5"
    N = 6 -> "1, 2, 3, 4, 5, 6"
*/

Console.Clear();

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
string stringNumber = "";
stringNumber = GetStringNumber(number, count, stringNumber);
PrintStringNumber(stringNumber, number);

string GetStringNumber(int number, int count, string stringNumber)
{  
    if(count > number) 
    {
        return stringNumber;
    }
    else
    {
        stringNumber += Convert.ToString(count);
        count++;
    }
    return GetStringNumber(number, count, stringNumber);
}

void PrintStringNumber(string stringNumber, int number)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"N = {number} -> \" ");

    for (int i = 0; i < stringNumber.Length; i++)
    {
        if (number -1 == i) Console.Write($"{stringNumber[i]} ");
        else Console.Write($"{stringNumber[i]}, ");
    }

    Console.WriteLine("\"");
    Console.ResetColor();
}