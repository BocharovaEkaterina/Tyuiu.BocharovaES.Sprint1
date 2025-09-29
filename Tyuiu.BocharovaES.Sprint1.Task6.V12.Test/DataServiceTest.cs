using Tyuiu.BocharovaES.Sprint1.Task6.V12.Lib;
namespace Tyuiu.BocharovaES.Sprint1.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "привет пока привет";
            bool res = ds.CheckLastWordRepetiton(value);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
