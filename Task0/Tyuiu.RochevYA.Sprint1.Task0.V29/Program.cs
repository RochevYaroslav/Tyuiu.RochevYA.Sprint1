using Tyuiu.RochevYA.Sprint1.Task0.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("2*9+7*2");
        Console.WriteLine(ds.Calculate());
        Console.ReadLine();
    }
}