using System;

Console.WriteLine("Введите температуру воздуха:");
double t = double.Parse(Console.ReadLine()) * 1.8 + 32; // переводим в градусы Фаренгейта
Console.WriteLine("Введите скорость ветра:");
double v = double.Parse(Console.ReadLine()) * 2.236936; // переводим в мили в час
Console.WriteLine("Эффективная температура = " + ((35.74 + 0.6215 * t + (0.4275 * t - 35.75) * Math.Pow(v, 0.16) - 32) / 1.8)); // считаем и переводим в градусы Цельсия
if(Math.Abs(t) > 50 || v > 120 || v < 3)
    Console.WriteLine("Результат может быть неверен!");