/*
    Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
    возводит число А в целую степень B с помощью рекурсии.
    A = 3; B = 5 -> 243 (3⁵)
    A = 2; B = 3 -> 8 
*/

//Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень числа: ");
int degree = Convert.ToInt32(Console.ReadLine());
int result = ExponentiationNumber(number, degree);
PrintResult(number, degree, result);

int ExponentiationNumber(int number, int degree, int result = 1)
{
    if (degree == 0) return result;
    else
    {
        result *= number;
        degree--;
        return ExponentiationNumber(number, degree, result);
    }
}

void PrintResult(int number, int degree, int result)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{number} в степени {degree} = {result}");
    Console.ResetColor();
}