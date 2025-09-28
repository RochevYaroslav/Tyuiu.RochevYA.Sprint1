using Tyuiu.RochevYA.Sprint1.Task0.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Рочев Ярослав Антонович | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема:  Создания итогового решения по спринту                            *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнил: Рочев Ярослав Антонович | ИБКСб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет                                   *");
        Console.WriteLine("* выражение 2*9+7*2 и печатает результат на экране.                       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        DataService obj = new DataService();
        Console.WriteLine(obj.Calculate());
    }
}