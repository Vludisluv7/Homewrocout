﻿/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


/*
int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double Vosvod(double A, double B)
{
    double result = Math.Pow(A, B);    
    return result;
}

double A = InputNum("Введите число A: ");
double B = InputNum("Введите число B: ");
double res = Vosvod(A , B); 
Console.WriteLine(res);
*/







/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


/*
int Length(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

int Sum(int a, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += a % 10;
        a /= 10;
    }
return sum;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int len = Length(a);
Console.Write($"Сумма цифр в числе {a} равно: {Sum(a,len)}");
*/











/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


/*
int[] randomArray = new int[8];

for (int i = 0; i < 8; i++)
{
randomArray[i] = new Random().Next(1,99);
Console.Write(randomArray[i] + " ");
}
*/