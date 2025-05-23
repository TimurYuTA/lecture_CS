﻿// Рисуем треугольник

Console.Clear();

int xa = 60, ya = 1,
    xb = 20, yb = 30,
    xc = 100, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;
int count = 0;

while (count < 10000)
{
    int number = new Random().Next(0, 3); // (0, 1, 2)
    if (number == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (number == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (number == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}
