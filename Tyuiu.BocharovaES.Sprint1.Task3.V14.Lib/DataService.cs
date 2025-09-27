using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BocharovaES.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {
            int a1 = (int) number % 10;
            int a2 = (int)(number/10)%10;
            int a3 = (int)(number/100);
            double numbered = a1 * 100 + a2 * 10 + a3;
            return Math.Round(numbered,3); 

        }
    }
}
