using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NUnitTestingLab
{
    public class Triangle
        //Mounika lab03
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int thirdAngle)

        {
            string result;
            // revert to correct condition
            if ((firstAngle + secondAngle + thirdAngle) == 180)
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            return result;
        }

    }
}