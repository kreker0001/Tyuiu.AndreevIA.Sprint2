﻿using Tyuiu.AndreevIA.Sprint2.Task6.V8.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил Андреев И. А. | РППб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Получение результата из switch                                    *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Андреев Иван Александрович | РППб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Введите день");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер месяца");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
var res = ds.FindDateOfPreviousDay(d, m);
Console.WriteLine(res);
Console.ReadKey();