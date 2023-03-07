﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
double result = Math.Pow(numberA, numberB);

if(numberB < 0)
{
    Console.WriteLine("Число 'B' не должно быть меньше нуля!");
}
else
{
    Console.WriteLine($"Число {numberA} в степени {numberB} = {Math.Pow(numberA, numberB)}");
}
