using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team3
{
    public class publicChecksAndOperations
    {
        private static Boolean userExit = false;

        /// <summary>
        /// converting int to string that represent day
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        public static string dayConvert(int day)
        {
            switch (day)
            {
                case 1:
                    return "Sunday";
                case 2:
                    return "Monday";
                case 3:
                    return "Tuesday";
                case 4:
                    return "Wednesday";
                case 5:
                    return "Thursday";
                case 6:
                    return "Friday";
                case 7:
                    return "Saturday";
                default:
                    return null;
            }
        }

        /// <summary>
        /// this method converts the day in string to date in int 
        /// for example sunday is 1
        /// </summary>
        /// <param name="Sday">string that represent day</param>
        /// <returns></returns>
        public static int convDayToInt(string Sday)
        {
            switch (Sday)
            {
                case "Sunday":
                    return 1;
                case "Monday":
                    return 2;
                case "Tuesday":
                    return 3;
                case "Wednsday":
                    return 4;
                case "Thursday":
                    return 5;
                case "Friday":
                    return 6;
                case "Saturday":
                    return 7;
                default:
                    return 0;
            }
        }


        /// <summary>
        /// that meant to convert the simple int hour from database to 
        /// readble known pattern
        /// </summary>
        /// <param name="hour"></param>
        /// <returns></returns>
        public static string hourConvertFromIntToString(int hour)
        {
            switch(hour)
            {
                case 0:
                    return "00:00";
                case 1:
                    return "01:00";
                case 2:
                    return "02:00";
                case 3:
                    return "03:00";
                case 4:
                    return "04:00";
                case 5:
                    return "05:00";
                case 6:
                    return "06:00";
                case 7:
                    return "07:00";
                case 8:
                    return "08:00";
                case 9:
                    return "09:00";
                case 10:
                    return "10:00";
                case 11:
                    return "11:00";
                case 12:
                    return "12:00";
                case 13:
                    return "13:00";
                case 14:
                    return "14:00";
                case 15:
                    return "15:00";
                case 16:
                    return "16:00";
                case 17:
                    return "17:00";
                case 18:
                    return "18:00";
                case 19:
                    return "19:00";
                case 20:
                    return "20:00";
                case 21:
                    return "21:00";
                case 22:
                    return "22:00";
                case 23:
                    return "23:00";
                default:
                    return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>convert simple int hour from database to 
        /// readble known pattern (will be used in create datatable i build schedule (of prof/inst)
        /// <param name="hour"></param>
        /// <returns></returns>
        public static int hourConvertFromStringToInt(string hour)
        {
            switch (hour)
            {
                case "08:00":
                case "800":
                case "8":
                    return 1;
                case "09:00":
                case "900":
                case "9":
                    return 2;
                case "10:00":
                case "1000":
                case "10":
                    return 3;
                case "11:00":
                case "1100":
                case "11":
                    return 4;
                case "12:00":
                case "1200":
                case "12":
                    return 5;
                case "13:00":
                case "1300":
                case "13":
                    return 6;
                case "14:00":
                case "1400":
                case "14":
                    return 7;
                case "15:00":
                case "1500":
                case "15":
                    return 8;
                case "16:00":
                case "1600":
                case "16":
                    return 9;
                case "17:00":
                case "1700":
                case "17":
                    return 10;
                case "18:00":
                case "1800":
                case "18":
                    return 11;
                case "19:00":
                case "1900":
                case "19":
                    return 12;
                case "20:00":
                case "2000":
                case "20":
                    return 13;
                case "21:00":
                case "2100":
                case "21":
                    return 14;
                default:
                    return 0;
            }
        }
        


        /// <summary>
        /// this function cheack if the string is unsigned long int;
        /// </summary>
        /// <param name="StringToCheck"></param>
        /// <returns></returns>
        public Boolean isNumericUlong(string StringToCheck)
        {
            ulong n;
            bool isNumeric = ulong.TryParse(StringToCheck, out n);

            if (ulong.TryParse(StringToCheck, out n))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// this function checks if the user exit from the system in some window;
        /// </summary>
        /// <returns>
        /// true or false;
        /// </returns>
        public Boolean didUserExit()
        {
            return userExit;
        }

        /// <summary>
        /// set exit for user as singletone class;
        /// </summary>
        public void setUserExit()
        {
            userExit = true;
        }

        /// <summary>
        /// convert sting to unsigned long int;
        /// </summary>
        /// <param name="toConv">
        /// </param>
        /// <returns></returns>
        public static ulong convertToUlong(string toConv)
        {
            return Convert.ToUInt32(toConv, 10);
        }

        /// <summary>
        /// convert sting to int;
        /// </summary>
        /// <param name="toConv"></param>
        /// <returns></returns>
        public int convertToInt(string toConv)
        {
            return Int32.Parse(toConv);
        }

    }


}
