using Tyuiu.AndreevIA.Sprint2.Task0.V23.Lib;

namespace Tyuiu.AndreevIA.Sprint2.Task0.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 105;
            int y = 795;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = { true, false, true, true, false, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
