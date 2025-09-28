using Tyuiu.RochevYA.Sprint1.Task2.V4.Lib;
namespace Tyuiu.RochevYA.Sprint1.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.CalculateSquare(4);
            Assert.AreEqual(16, res);
        }
    }
}
