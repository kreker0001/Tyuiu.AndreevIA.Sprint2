using Tyuiu.AndreevIA.Sprint2.Task0.V23.Lib;

DataService ds = new DataService();

int x = 105;
int y = 795;
bool[] res = new bool[6];
res = ds.GetCompareOperations(x, y);

Console.Title = "Спринт #1 | Выполнил Андреев И. А. | РППб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема. Операции сравнения                                                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #23                                                             *");
Console.WriteLine("* Выполнил: Андреев Иван Александрович | РППб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических      *");
Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):        *");
Console.WriteLine("* (True, False, True, True, False, True),  при x = 105, y = 795           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("X = " + x);
Console.WriteLine("Y = " + y);


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}

Console.ReadLine();