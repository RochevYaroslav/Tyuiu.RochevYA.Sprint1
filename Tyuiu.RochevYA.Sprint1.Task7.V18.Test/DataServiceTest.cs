using Tyuiu.RochevYA.Sprint1.Task7.V18.Lib;
namespace Tyuiu.RochevYA.Sprint1.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(90, 0);
            Console.WriteLine(res);
            Assert.AreEqual(90.02, res);
        }
    }
}
