using Tyuiu.RochevYA.Sprint1.Task7.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Число Х:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Число Y:");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(ds.Calculate(x, y));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}