﻿// Задача 8: Напишите программу, 
//которая на вход принимает число (N), 
//а на выходе показывает все чётные числа 
//от 1 до N.

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

for (int index=2; index<=num; index++)
if(index%2==0)
Console.WriteLine($"Четные числа{index} ");