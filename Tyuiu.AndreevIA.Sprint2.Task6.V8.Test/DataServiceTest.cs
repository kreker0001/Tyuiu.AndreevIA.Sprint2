using Tyuiu.AndreevIA.Sprint2.Task6.V8.Lib;

namespace Tyuiu.AndreevIA.Sprint2.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            Assert.AreEqual("28.02", ds.FindDateOfPreviousDay(1, 3));
            Assert.AreEqual("25.02", ds.FindDateOfPreviousDay(26, 2));
            Assert.AreEqual("2.06", ds.FindDateOfPreviousDay(3, 6));
        }
    }
}
