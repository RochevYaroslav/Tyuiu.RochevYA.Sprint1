using Tyuiu.RochevYA.Sprint1.Task6.V10.Lib;
namespace Tyuiu.RochevYA.Sprint1.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string res = ds.DeleteMiddleLetter("Hello world here we go again");
            Assert.AreEqual("Helo wold here we go agin", res);
        }
    }
}
