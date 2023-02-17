﻿// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
// 918 = 9 * 100 + 1 * 10 + 8 918 / 100 = 9
// 98 = 9 * 10 + 8

Console.Clear();
int num = new Random().Next(100,1000);
Console.WriteLine($"Num = {num}");
int num1 = num / 100;
int num2 = num % 10;

Console.WriteLine($"New = {num1}{num2}");

// или
// Console.Clear();
//  int num = new Random().Next(100, 1000);
//  int result = (num / 100) * 10 + num % 10;
//  Console.WriteLine($"{num} -> {result}");
//  или Console.WriteLine($"{num} -> {num/100}{num%10}");