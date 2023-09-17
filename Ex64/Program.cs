/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int SetNumber(string message)
{
    Console.Write(message);
    string arrLength = Console.ReadLine();
    int result = int.Parse(arrLength);
    return result;
}

string PrintNumbers(int start, int end)
{
    if(start == end)
    {
        return start.ToString();
    }
    return end + " " + PrintNumbers(start, end - 1);
}

int num = SetNumber("Задайте значение N: ");
Console.Write(PrintNumbers(1, num));
