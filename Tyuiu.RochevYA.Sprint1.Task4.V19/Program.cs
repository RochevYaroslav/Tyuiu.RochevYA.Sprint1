using Tyuiu.RochevYA.Sprint1.Task4.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Введите первое число: ");
        double x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        double y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ответ: " + ds.Calculate(x, y));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}