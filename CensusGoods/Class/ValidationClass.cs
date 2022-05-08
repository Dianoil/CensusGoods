using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;
namespace CensusGoods.Class
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
            int s = 7;
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
        public static bool ValidateCompany(string company)
        {
            int s = 0;
            while (s < company.Length)
            {
                if (company[s] >= 'А' && company[s] <= 'Я' ||
                    company[s] >= 'а' && company[s] <= 'я' ||
                    ((company[s] == '-' || company[s] == ' ') &&
                    (company[s] >= 'А' && company[s] <= 'Я' ||
                    company[s] >= 'а' && company[s] <= 'я')))
                {
                    s++;
                }
                else return false;
            }
            return true;

        }
        public static bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                    RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$" ,
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        public static bool ValidateINN(string inn)
        {
            int s = 11;
            while (s == inn.Length)
            {
                if (inn[s] >= '0' && inn[s] <= '9')              
                {
                    s++;
                }
                else return false;
            }
            return true;
        }
        public static bool ValidateOGRN(string ogrn)
        {
            int s = 12;
            while (s == ogrn.Length)
            {
                if (ogrn[s] >= '0' && ogrn[s] <= '9')
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
