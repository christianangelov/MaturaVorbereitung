using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBase
{
    public static class PaymentCheck
    {

        public static bool CheckCCN(string ccn)
        {
            if(ccn != null && ccn.Length != 16) return false;

            int sum = 0;

            for (int i = 0; i < ccn.Length; i++)
            {
                int tmp = ccn.ElementAt(i);
                int number = tmp - '0';
                int product;
                if (i % 2 == 0) product = number * 1; 
                else product = number * 2;

                if (product > 9) product -= 9;
                sum += product;
            }

            bool isValid = (sum % 10 == 0);

            return isValid;

        }
    }
}
