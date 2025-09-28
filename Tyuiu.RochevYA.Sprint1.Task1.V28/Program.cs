using Tyuiu.RochevYA.Sprint1.Task1.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {

        DataService obj = new DataService();
        Console.WriteLine("Введите первое число: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ответ: " + obj.Calculate(x));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}