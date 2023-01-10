using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBase
{
    public static class PatientExtension
    {
        public static bool CheckFirstname(string firstName)
        {
            if (firstName.Length < 3)
            {
                return false;
            }

            return true;
        }

        public static bool CheckLastName(string lastName)
        {
            if (lastName.Length < 3)
            {
                return false;
            }
            return true;
        }

        public static bool CheckSSN(string ssn)
        {
            var result = ssn.Length == 10;
            int[] weight = new int[] { 3, 7, 9, 5, 8, 4,2,1,6 };
            int sum = 0;
            for (int i = 0; i < ssn.Length -1; i++)
            {
                if (Char.IsLetter(ssn[i])) return false;
                if (i < 3)
                {
                    sum += ((ssn[i] - '0') * weight[i]);
                }
                else
                {
                    sum += ((ssn[i + 1] - '0') * weight[i]);
                }
                
                
            }
            int checksum = sum % 11;
            if((ssn[3] - '0') == checksum)
            {
                return true;
            }
            return false;
        }
    }
}
