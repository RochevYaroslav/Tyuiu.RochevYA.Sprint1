using Tyuiu.RochevYA.Sprint1.Task3.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Введите первое число: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ответ: "+ds.VerstsToKilometers(x));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}