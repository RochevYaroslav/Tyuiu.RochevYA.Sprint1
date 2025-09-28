using Tyuiu.RochevYA.Sprint1.Task5.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Количество секунд: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(ds.SecondsToHours(x));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}