﻿Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
int max;
if (a > b) max = a;
else max = b;
if (c > max) max = c;
Console.Write("max = ");
Console.WriteLine(max);