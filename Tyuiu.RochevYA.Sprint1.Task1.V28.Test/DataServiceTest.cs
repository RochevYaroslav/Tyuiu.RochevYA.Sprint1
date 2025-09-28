using Tyuiu.RochevYA.Sprint1.Task1.V28.Lib;
namespace Tyuiu.RochevYA.Sprint1.Task1.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(9);
            Assert.AreEqual(1.8, res);
        }
    }
}
