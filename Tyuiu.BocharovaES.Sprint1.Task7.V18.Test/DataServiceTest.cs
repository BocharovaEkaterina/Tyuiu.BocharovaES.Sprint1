using Tyuiu.BocharovaES.Sprint1.Task7.V18.Lib;
namespace Tyuiu.BocharovaES.Sprint1.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 1.392;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
