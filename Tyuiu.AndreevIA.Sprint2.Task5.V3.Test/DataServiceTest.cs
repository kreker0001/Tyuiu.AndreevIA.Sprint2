using Tyuiu.AndreevIA.Sprint2.Task5.V3.Lib;

namespace Tyuiu.AndreevIA.Sprint2.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {

        [TestMethod]
        public void methods()
        {
            DataService ds = new DataService();
            Assert.AreEqual("понедельник", ds.FindDayName(1));
            Assert.AreEqual("вторник", ds.FindDayName(2));
            Assert.AreEqual("среда", ds.FindDayName(3));
            Assert.AreEqual("четверг", ds.FindDayName(4));
            Assert.AreEqual("пятница", ds.FindDayName(5));
            Assert.AreEqual("суббота", ds.FindDayName(6));
            Assert.AreEqual("воскресенье", ds.FindDayName(7));
            Assert.AreEqual("неверный день недели", ds.FindDayName(8));
        }
        
    }
}
