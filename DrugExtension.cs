using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBase
{
    public static class DrugExtension
    {
      

        public static bool CheckDrugNumber(string number)
        {
            var result = number.Length == 10;
            int res = 0;

            for (int i = 0; i < number.Length - 1; i++)
            {
                res += (number[i] - '0') * (i + 1);
            }
            res = res % 11;

            if (res == 10)
            {
                if (number[^1] == 'X')
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                if (res == number[9] - '0')
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
        public static bool CheckDesignation(string designation)
        {
            if (designation.Length < 10)
            {
                return false;
            }
            return true;

        }
    }
}
