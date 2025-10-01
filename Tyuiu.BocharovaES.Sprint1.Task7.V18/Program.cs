using Tyuiu.BocharovaES.Sprint1.Task7.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила: Бочарова Е. С. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнила: Бочарова Екатерина Сергеевна | ИИПб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ :                                                               *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
        Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                      1+sin^2(x+y)                                       *");
        Console.WriteLine("*                  z= ------------- +x                                    *");
        Console.WriteLine("*                      |      2x    |                                     *");
        Console.WriteLine("*                    2+|x- ---------|                                     *");
        Console.WriteLine("*                      |   1+x^2*y^2|                                     *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");

        double x, y;
        Console.WriteLine("Введите значение Х");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение Y");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(ds.Calculate(x, y));

    }
}