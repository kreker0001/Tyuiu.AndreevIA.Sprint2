using Tyuiu.AndreevIA.Sprint2.Task5.V3.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил Андреев И. А. | РППб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Тернарный оператор                                                *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнил: Андреев Иван Александрович | РППб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Составить программу, которая в зависимости от порядка номера дня недели *");
Console.WriteLine("* (1, 2, ..., 7) выводит на экран его название (понедельник, вторник,     *");
Console.WriteLine("* ..., воскресенье).                                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int value;

Console.WriteLine("Введите значение value (от 1 до 7)");

value = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.FindDayName(value));
Console.ReadKey();