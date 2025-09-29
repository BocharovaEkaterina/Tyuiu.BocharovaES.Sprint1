using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BocharovaES.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string value)
        {
            int postprob = value.LastIndexOf(' ');
            if (postprob == -1)
            {
                return false;
            }
            string postclovo = value.Substring(postprob + 1);
            string newvalue = value.Substring(0, postprob);
            return newvalue.Contains(postclovo);
        }
    }
}
