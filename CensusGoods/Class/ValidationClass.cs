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
            int t = 0;
            if (name != "ФИО Руководителя склада"
                && name != "ФИО Руководителя компании" && name != "ФИО Работника")
            {
                if (t < name.Length)
                {
                    while (s < name.Length)
                    {
                        if ((name[s] >= 'А' && name[s] <= 'Я' || name[s] >= 'а' && name[s] <= 'я' )||
                            (name[s] == '-' || name[s] == ' '))
                        {
                            s++;
                        }
                        else return false;
                    }
                }
                else return false;
            }
            else return false;
            return true;
        }
        public static bool ValidateTariff(string name)
        {
            int s = 0;
            int t = 0;
            if (name != "Название тарифа")
            {
                if (t < name.Length)
                {
                    while (s < name.Length)
                    {
                        if ((name[s] >= 'А' && name[s] <= 'Я' || name[s] >= 'а' && name[s] <= 'я') ||
                            (name[s] == '-' || name[s] == ' ') || (name[s] >=0 && name[s] <=9))
                        {
                            s++;
                        }
                        else return false;
                    }
                }
                else return false;
            }
            else return false;
            return true;
        }
        public static bool ValidatePassw(string passw)
        {
            int t = 7;

            if (passw.Length >= t)
            {
                for (int i = 0; i < passw.Length; i++)
                    if ((passw[i] >= '0') && (passw[i] <= '9'))
                    {
                        for (int d = 0; d < passw.Length; d++)
                                for (int j = 0; j < passw.Length; j++)
                                    if ((passw[j] >= 'a') && (passw[j] <= 'z'))
                                    {
                                        for (int k = 0; k < passw.Length; k++)
                                        {
                                            if ((passw[k] >= 'A') && (passw[k] <= 'Z'))
                                                return true;
                                        }
                                        return false;
                                    }
                        return false;
                    }
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ValidateLogin(string login)
        {
            int t = 3;
            int s = 0;
            if (login != "Логин")
            {
                if (login.Length >= t)
                {
                    for (int i = 0; i < login.Length; i++)
                        if ((login[i] >= '0') && (login[i] <= '9'))
                        {
                            for (int d = 0; d < login.Length; d++)
                                for (int j = 0; j < login.Length; j++)
                                    if ((login[j] >= 'a') && (login[j] <= 'z'))
                                    {
                                        for (int k = 0; k < login.Length; k++)
                                        {
                                            if ((login[k] >= 'A') && (login[k] <= 'Z'))
                                                return true;
                                        }
                                        return false;
                                    }
                            return false;
                        }
                    return true;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateCompany(string company)
        {
            int s = 0;
            int t = 0;

            if (company.Length >= t)
            {
                for (int i = 0; i < company.Length; i++)
                    if ((company[i] >= '0') && (company[i] <= '9'))
                    {
                        for (int d = 0; d < company.Length; d++)
                            if ((company[d] >= '#') && (company[d] <= '&') || company[d] == '^' || company[d] == '_')
                            {
                                for (int j = 0; j < company.Length; j++)
                                    if ((company[j] >= 'а') && (company[j] <= 'я') || (company[j] >= 'a') && (company[j] <= 'z'))
                                    {
                                        for (int k = 0; k < company.Length; k++)
                                        {
                                            if ((company[k] >= 'А') && (company[k] <= 'Я') || (company[j] >= 'A') && (company[j] <= 'Z'))
                                                return true;
                                        }
                                        return false;
                                    }
                                return false;

                            }
                        return false;
                    }
                return true;
            }
            else
            {
                return false;
            }
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
            int s = 0;
            int t = 11;
            if (inn != "ИНН")
            {
                if (t == inn.Length)
                {
                    while (s == inn.Length)
                    {
                        if (inn[s] >= '0' && inn[s] <= '9')
                        {
                            s++;
                        }
                        else return false;

                    }

                }
                else return false;

            }
            else return false;
            return true;
        }
        public static bool ValidateOGRN(string ogrn)
        {
            int s = 0;
            int t = 12;
            if (ogrn != "ОГРН")
            {
                if (t == ogrn.Length)
                {
                    while (s == ogrn.Length)
                    {
                        if (ogrn[s] >= '0' && ogrn[s] <= '9')
                        {
                            s++;
                        }
                        else return false;

                    }

                }
                else return false;

            }
            else return false;
            return true;
        }
        public static bool ValidateDiscount(string disk)
        {
            int s = 0;
            int t = 3;
            if (disk != "Персональная скидка")
            {
                if (t >= disk.Length)
                {
                    while (s == disk.Length)
                    {
                        if (disk[s] >= '0' && disk[s] <= '9')
                        {
                            s++;
                        }
                        else return false;

                    }

                }
                else return false;

            }
            else return false;
            return true;
        }
        public static bool ValidatePersTariff(string disk)
        {
            int s = 0;
            if (disk != "Процент по тарифу")
            {
                if (s <= disk.Length)
                {
                    for (int j = 0; j < disk.Length; j++)
                        if ((disk[j] >= '0') && (disk[j] <= '9'))
                        {
                            for (int k = 0; k < disk.Length; k++)
                            {
                                if (disk[k] == ',')
                                    return true;
                            }
                            return false;
                        }
                    return false;
                }
                else return false;

            }
            return true;
        }
        
        public static bool ValidatePhone(string phone)
        {

            int s = 0;

            if (phone != "+7 (___) ___-__-__")
            {
                while (s == phone.Length)
                {
                    if (phone[s] >= '0' && phone[s] <= '9')
                    {
                        s++;
                    }
                    else return false;
                }
                return true;
            }
            else return false;
        }
        public static bool ValidateDate(DateTime? birth)
        {
            try
            {
                DateTime? b = birth;
                while (b <= DateTime.Now)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

    }
}
