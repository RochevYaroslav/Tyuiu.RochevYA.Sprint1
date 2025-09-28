using Tyuiu.RochevYA.Sprint1.Task5.V4.Lib;
namespace Tyuiu.RochevYA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.SecondsToHours(13257);
            Assert.AreEqual(3, res);
        }
    }
}
