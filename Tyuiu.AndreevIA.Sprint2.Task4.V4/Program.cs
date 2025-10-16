using Tyuiu.AndreevIA.Sprint2.Task4.V4.Lib;

DataService ds = new DataService();


Console.Title = "Спринт #2 | Выполнил Андреев И. А. | РППб-25-1";
Console.WriteLine("**************************************************************************");
Console.WriteLine("* Спритн #2                                                              *");
Console.WriteLine("* Тема: Создания итогого решения по спринту                              *");
Console.WriteLine("* Задание #4                                                             *");
Console.WriteLine("* Вариант #4                                                             *");
Console.WriteLine("* Выполнил: Андреев Иван Александрович | РППб-25-1                       *");
Console.WriteLine("**************************************************************************");
Console.WriteLine("*                                                                        *");
Console.WriteLine("**************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("**************************************************************************");


Console.WriteLine("Введите значение X:");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y:");
double y = Convert.ToDouble(Console.ReadLine());

double res = ds.Calculate(x, y);

Console.WriteLine("**************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("**************************************************************************");
Console.WriteLine("Значение функции = " + res);
Console.ReadKey();