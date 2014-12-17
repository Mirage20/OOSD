using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SalesLeadsManagementSystem.General
{
    static class Rules
    {

        

        public static bool isPhonenumber(string phoneNumber)
        {
            if (phoneNumber.Length == 10 && isIntNumber(phoneNumber) && phoneNumber[0].CompareTo('0') == 0)
                return true;
            return false;
            

        }
        public static bool isIntNumber(string number)
        {
            Int32 result;
            return Int32.TryParse(number,out result);
        }

        public static bool isDecimalNumber(string number)
        {
            decimal result;
            return Decimal.TryParse(number, out result) && result>=0;
        }

        public static decimal textToPrice(string value)
        {
            if(value.Equals("") || !isDecimalNumber(value))
            {
                return 0.00m;
            }
            return Convert.ToDecimal(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        /// <remarks>
        /// dont use single quote inside the sql quarry otherwise NULL is not valid
        /// </remarks>
        public static string toSQLDate(DateTime date)
        {
            if (date.ToString("yyyy-MM-dd").Equals("0001-01-01"))
            {
                return "NULL";
            }
            else
            {
                return "'"+date.ToString("yyyy-MM-dd")+"'";
            }
        }

        public static bool isEmail(string email)
        {
            if (email.Trim().Equals(""))
                return true;

            string pattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);

        }

        public static bool yesnoToBoolean(string answer)
        {
            if(answer.ToLower().Equals("yes"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string boolToYesNo(bool yes_no)
        {
            if (yes_no)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        public static DateTime dbNullDateField(MySql.Data.MySqlClient.MySqlDataReader sqlReader,int columnIndex)
        {
            if (!sqlReader.IsDBNull(columnIndex))
                return sqlReader.GetDateTime(columnIndex);
            else
                return new DateTime(1, 1, 1);

        }

        public static void nullDateTimePick(System.Windows.Forms.DateTimePicker dateTimePicker,DateTime date)
        {
            if (date.ToString("yyyy-MM-dd").Equals("0001-01-01"))
            {
                dateTimePicker.Checked=false;
                dateTimePicker.CustomFormat = "N/A";
            }
            else
            {
                dateTimePicker.CustomFormat = "yyyy-MM-dd";
                dateTimePicker.Value = date; ;
            }
        }

        public static byte[] fileToBytes(string fullFilePath)
        {
            if (!fullFilePath.Equals(""))
            {
                FileStream fileStream = new FileStream(fullFilePath, FileMode.Open, FileAccess.Read);
                long byteLength = fileStream.Length;
                byte[] binaryData = new byte[byteLength];
                fileStream.Read(binaryData, 0, (int)byteLength);
                fileStream.Close();
                return binaryData;
            }
            return new byte[0];
        }
        
        public static void bytesToFile(string fullFilePath,byte[] binaryData)
        {
            FileStream fileStream = new FileStream(fullFilePath, FileMode.Create, FileAccess.Write);
            fileStream.Write(binaryData, 0, binaryData.Length);
            fileStream.Close();
            
        }
    }
}
