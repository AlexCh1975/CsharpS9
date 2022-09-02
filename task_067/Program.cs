/*
    Задача 67: Напишите программу, которая будет принимать на вход число и
    возвращать сумму его цифр.
    453 -> 12
    45 -> 9
*/

//Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num = number;

int length = GetLengthNumber(number);
int sumNumber = GetSumNumber(number, length, num);
PrintSumNumbers(number, sumNumber);

int GetLengthNumber(int number, int length = 0)
{
    if (number > 10)
    {
        number = number / 10;
        length++;
        return GetLengthNumber(number, length);
    }
    return length +1;
}

int GetSumNumber(int number, int length, int num, int sum = 0)
{
    if (length == 0) return sum;
    else
    {
        num = (num / 10);
        sum += (number - (num * 10));
        number = num; 
        length--;
        return GetSumNumber(number, length, num, sum);
    }
}

void PrintSumNumbers(int number, int sumNumber)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{number} -> {sumNumber}");
    Console.ResetColor();
}