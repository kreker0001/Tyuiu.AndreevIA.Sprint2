﻿using Tyuiu.AndreevIA.Sprint2.Task2.V4.Lib;


Console.Title = "Спринт #2 | Выполнил Андреев И. А. | РППб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема. Оператор if – полная и короткая форма записи                      *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Андреев Иван Александрович | РППб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
Console.WriteLine("* И вычисляет находится ли точка в заштрихованной области                 *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение переменной Х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение переменной Y: ");
int y = Convert.ToInt32(Console.ReadLine());

DataService ds = new DataService();
bool res = ds.CheckDotInShadedArea(x, y);

Console.WriteLine("**************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("**************************************************************************");

if (res)
{
    Console.WriteLine("Точка находиться в заштрихованной области ");
}
else
{
    Console.WriteLine("Точка не находится в заштрихованной области");
}


Console.ReadKey();