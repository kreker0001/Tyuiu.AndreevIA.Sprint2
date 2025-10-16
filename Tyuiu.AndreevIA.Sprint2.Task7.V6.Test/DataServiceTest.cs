using Tyuiu.AndreevIA.Sprint2.Task7.V6.Lib;


namespace Tyuiu.AndreevIA.Sprint2.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.CheckDotInShadedArea(0, 1.5), true);
        }
    }
}
