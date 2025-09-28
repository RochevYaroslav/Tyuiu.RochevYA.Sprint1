using Tyuiu.RochevYA.Sprint1.Task4.V19.Lib;
namespace Tyuiu.RochevYA.Sprint1.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(3, 6);
            Assert.AreEqual(9, res);
        }
    }
}
