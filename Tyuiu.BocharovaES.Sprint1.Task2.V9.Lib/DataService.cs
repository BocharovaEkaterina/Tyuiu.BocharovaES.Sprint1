using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BocharovaES.Sprint1.Task2.V9.Lib
{
    public class DataService : ISprint1Task2V9
    {
        public double CalculateVolumeCircle(int r)
        {
            const double pi = 3.1415926535;
            return Math.Round(r*r*r*pi*4/3, 3);
        }
    }
}
