using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BrezinaYS.Sprint2.Task7.V11.Lib
{
    public class DataService : ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && ((x > -1) && (x < 0) && (y > -1) && (y < 1))) || ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1)) && (y - x >= 0))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
           


            
        }
    }
}
