using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isikukood
{
    public class IdCode
    {
        private readonly string _idCode;

        public IdCode(string idCode)
        {
            _idCode = idCode;
        }

        private bool IsValidLength()
        {
            return _idCode.Length == 11;
        }

        private bool ContainsOnlyNumbers()
        {
            // return _idCode.All(Char.IsDigit);

            for (int i = 0; i < _idCode.Length; i++)
            {
                if (!Char.IsDigit(_idCode[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private int GetGenderNumber()
        {
            return Convert.ToInt32(_idCode.Substring(0, 1));
        }

        private bool IsValidGenderNumber()
        {
            int genderNumber = GetGenderNumber();
            return genderNumber > 0 && genderNumber < 7;
        }

        private int Get2DigitYear()
        {
            return Convert.ToInt32(_idCode.Substring(1, 2));
        }

        public int GetFullYear()
        {
            int genderNumber = GetGenderNumber();
            // 1, 2 => 18xx
            // 3, 4 => 19xx
            // 5, 6 => 20xx
            return 1800 + (genderNumber - 1) / 2 * 100 + Get2DigitYear();
        }

        public int GetAge()
        {
            int year = GetFullYear();
            int age = DateTime.Now.Year - year;
            return age;
        }

        private int GetMonth()
        {
            return Convert.ToInt32(_idCode.Substring(3, 2));
        }

        private int GetHospitalNumber()
        {
            return Convert.ToInt32(_idCode.Substring(7, 3));
        }

        public string GetHospital()
        {
            int num = GetHospitalNumber();
            string x = "";
            if (num >= 001 && num <= 010) { x = "Kuressaare haigla"; }
            else if (num >= 011 && num <= 020) { x = "Tartu Ülikooli Naistekliinik"; }
            else if (num >= 021 && num <= 150) { x = "Ida-Tallinna keskhaigla, Pelgulinna sünnitusmaja (Tallinn)"; }
            else if (num >= 151 && num <= 160) { x = "Keila haigla"; }
            else if (num >= 161 && num <= 220) { x = "Rapla haigla, Loksa haigla, Hiiumaa haigla (Kärdla)"; }
            else if (num >= 221 && num <= 270) { x = "Ida-Viru keskhaigla (Kohtla-Järve, endine Jõhvi)"; }
            else if (num >= 271 && num <= 370) { x = "Maarjamõisa kliinikum (Tartu), Jõgeva haigla"; }
            else if (num >= 371 && num <= 420) { x = "Narva haigla"; }
            else if (num >= 421 && num <= 470) { x = "Pärnu haigla "; }
            else if (num >= 471 && num <= 490) { x = "Haapsalu haigla"; }
            else if (num >= 491 && num <= 520) { x = "Järvamaa haigla (Paide)"; }
            else if (num >= 521 && num <= 570) { x = "Rakvere haigla, Tapa haigla"; }
            else if (num >= 571 && num <= 600) { x = "Valga haigla "; }
            else if (num >= 601 && num <= 650) { x = "Viljandi haigla"; }
            else if (num >= 651 && num <= 700) { x = "Lõuna-Eesti haigla (Võru), Põlva haigla " + num; }
            else { x = "unknown"; }
            return x;
        }

        private bool IsValidMonth()
        {
            int month = GetMonth();
            return month > 0 && month < 13;
        }

        private static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
        }
        private int GetDay()
        {
            return Convert.ToInt32(_idCode.Substring(5, 2));
        }

        private bool IsValidDay()
        {
            int day = GetDay();
            int month = GetMonth();
            int maxDays = 31;
            if (new List<int> { 4, 6, 9, 11 }.Contains(month))
            {
                maxDays = 30;
            }
            if (month == 2)
            {
                if (IsLeapYear(GetFullYear()))
                {
                    maxDays = 29;
                }
                else
                {
                    maxDays = 28;
                }
            }
            return 0 < day && day <= maxDays;
        }

        private int CalculateControlNumberWithWeights(int[] weights)
        {
            int total = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                total += Convert.ToInt32(_idCode.Substring(i, 1)) * weights[i];
            }
            return total;
        }

        private bool IsValidControlNumber()
        {
            int controlNumber = Convert.ToInt32(_idCode[^1..]);
            int[] weights = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            int total = CalculateControlNumberWithWeights(weights);
            if (total % 11 < 10)
            {
                return total % 11 == controlNumber;
            }
            // second round
            int[] weights2 = { 3, 4, 5, 6, 7, 8, 9, 1, 2, 3 };
            total = CalculateControlNumberWithWeights(weights2);
            if (total % 11 < 10)
            {
                return total % 11 == controlNumber;
            }
            // third round, control number has to be 0
            return controlNumber == 0;
        }

        public bool IsValid()
        {
            return IsValidLength() && ContainsOnlyNumbers()
                && IsValidGenderNumber() && IsValidMonth()
                && IsValidDay()
                && IsValidControlNumber();
        }

        public DateOnly GetBirthDate()
        {
            int day = GetDay();
            int month = GetMonth();
            int year = GetFullYear();
            return new DateOnly(year, month, day);
        }
    }
}
