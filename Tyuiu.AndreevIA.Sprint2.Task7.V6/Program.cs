using Tyuiu.AndreevIA.Sprint2.Task7.V6.Lib; 

Console.Title = "Спринт #2 | Выполнил Андреев И. А. | РППб-25-1";

Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #2                                                            *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту              *");
Console.WriteLine("* Задание #7                                                           *");
Console.WriteLine("* Вариант #6                                                           *");
Console.WriteLine("* Выполнил: Андреев Иван Александрович | РППб-25-1                     *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:Написать программу на C#, которая запрашивает исходные данные*");
Console.WriteLine("* и вычисляет, находится ли точка в заштрихованной области.            *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");

Console.WriteLine("Введите координату X:");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y:");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

DataService ds = new DataService();
bool res = ds.CheckDotInShadedArea(x, y);

Console.WriteLine($"Ответ = {res}");
Console.ReadKey();