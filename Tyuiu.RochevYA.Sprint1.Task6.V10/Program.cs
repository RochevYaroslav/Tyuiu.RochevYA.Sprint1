using Tyuiu.RochevYA.Sprint1.Task6.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Текст: ");
        var text = Console.ReadLine();
        Console.WriteLine(ds.DeleteMiddleLetter(text));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}
