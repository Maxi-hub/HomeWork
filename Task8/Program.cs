﻿// Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = (number % 2);
int total = 0;

for (int i = 2; i <= number; i++)
{
    total = i++;
    Console.Write($"{total} ","");
}