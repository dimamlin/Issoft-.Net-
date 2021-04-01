using System;

Console.Write("Введите первые 9 цифр ISBN: ");
String code = Console.ReadLine();
int sum = 0;
for(int i = 0, position_weight = 10; i < code.Length; i++, position_weight--) // считаем значение выражения без контрольной цифры
    sum += (code[i] - '0') * position_weight;
Console.WriteLine((11 - (sum % 11)) == 10 ? "Итоговый ISBN: " + code + "X" : "Итоговый ISBN: " + code + (11 - (sum % 11))); // вычисляем контрольную цифру и выводим итоговый код