﻿/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SetNumber(string message)
{
    Console.Write(message);
    string arrLength = Console.ReadLine();
    int result = int.Parse(arrLength);
    return result;
}

int GetSum(int start, int end)
{
    if(start == end)
    {
        return start;
    }
    return start + GetSum(start + 1, end);
}

int start = SetNumber("Задайте значение M: ");
int end = SetNumber("Задайте значение N: ");
Console.Write(GetSum(start, end));
