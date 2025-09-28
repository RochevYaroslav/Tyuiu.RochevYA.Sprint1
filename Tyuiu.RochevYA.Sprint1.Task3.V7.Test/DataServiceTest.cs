using Tyuiu.RochevYA.Sprint1.Task3.V7.Lib;
namespace Tyuiu.RochevYA.Sprint1.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.VerstsToKilometers(6);
            Assert.AreEqual(6400.8, res);
        }
    }
}
