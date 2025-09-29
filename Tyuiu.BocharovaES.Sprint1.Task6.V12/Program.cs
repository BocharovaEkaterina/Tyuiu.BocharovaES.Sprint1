using Tyuiu.BocharovaES.Sprint1.Task6.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила: Бочарова Е. С. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Работа со строками класс String                                   *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнила: Бочарова Екатерина Сергеевна | ИИПб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ :                                                               *");
        Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что           *");
        Console.WriteLine("* впоследнее слово строки входит в нее еще раз.                           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
        Console.WriteLine("***************************************************************************");

        string value;
        Console.WriteLine("Введите строку с маленькой буквы");
        value = Console.ReadLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        if (ds.CheckLastWordRepetiton(value))
        {
            Console.WriteLine("Последнее слово в строке входит в нее ещё раз");
        }
        else
        {
            Console.WriteLine("Последнее слово в строке не входит в нее ещё раз");
        }
    }
}