using Tyuiu.AndreevIA.Sprint2.Task3.V18;

DataService ds = new DataService();
Console.Title = "Спринт #2 | Выполнил Андреев И. А. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнил: Андреев Иван Александрович | РППб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит      *");
Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение до    *");
Console.WriteLine("* трех знаков после запятой                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Введите значение переменной X:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
var res = ds.Calculate(x);
Console.WriteLine("Значение функции " + res);
Console.ReadKey();