using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RochevYA.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int SecondsToHours(int x)
        {
            return Convert.ToInt32(x / 60 / 60);
        }
    }
}
