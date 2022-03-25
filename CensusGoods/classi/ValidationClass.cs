using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusGoods.classi
{
    class ValidationClass
    {
        public static bool ValidateFIO(string name)
        {
            int s = 0;
            while (s < name.Length)
            {
                if (name[s] >= 'А' && name[s] <= 'Я' ||
                    name[s] >= 'а' && name[s] <= 'я' ||
                    ((name[s] == '-' || name[s] == ' ') &&
                    (name[s] >= 'А' && name[s] <= 'Я' ||
                    name[s] >= 'а' && name[s] <= 'я')))
                {
                    s++;
                }
                else return false;
            }
            return true;
        }
        public static bool ValidatePassw(string passw)
        {
            int s = 0;
            while (s < passw.Length)
            {
                if (passw[s] >= 'А' && passw[s] <= 'Я' || passw[s] >= 'а' && passw[s] <= 'я' ||
                    (
                    (passw[s] == '-' || passw[s] == ' ') && (passw[s] >= 'А' && passw[s] <= 'Я' || passw[s] >= 'а' && passw[s] <= 'я')
                    )
                   )
                {
                    s++;
                }
                else return false;
            }
            return true;
        }
        //public static bool ValidateBirth(DateTime birth)
        //{
        //    try
        //    {
        //        DateTime b = birth;
        //        while (b <= DateTime.Now)
        //        {
        //            return true;
        //        }
        //        return false;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

    }
}
