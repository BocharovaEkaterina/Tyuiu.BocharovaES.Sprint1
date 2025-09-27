using Tyuiu.BocharovaES.Sprint1.Task3.V14.Lib;
namespace Tyuiu.BocharovaES.Sprint1.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 123;
            double wain = 321;
            var res = ds.ReverseNumber(number);
            Assert.AreEqual(wain, res);
        }
    }
}
