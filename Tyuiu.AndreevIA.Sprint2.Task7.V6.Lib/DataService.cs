using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AndreevIA.Sprint2.Task7.V6.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            double r = Math.Pow(x,2) + Math.Pow(y,2);

            return (r >= 1 && r <= 4 && y >= 0);
        }
    }
}
