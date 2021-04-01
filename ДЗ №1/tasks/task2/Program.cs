using System;

Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
while(a <= b)
{
    int temp = a, counter = 0;
    while (temp != 0)
    {
        if ((temp & 1) == 1) // проверяем последнюю цифру двоичной записи
            counter++;       // если 1, то увеличиваем счетчик
        temp >>= 1;          // делаем сдвиг вправо для проверки следующей цифры
    }
    if (counter == 4)
        Console.Write(a + " ");
    a++;
}