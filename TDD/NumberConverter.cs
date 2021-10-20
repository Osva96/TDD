using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class NumberConverter
    {
        public string ConvertBaseNumbers(int numBaseInitial, int numBaseConvert, string number)
        {
            string result = "";

            switch(numBaseInitial)
            {
                case 2:
                    if (numBaseConvert == 10) {
                        result = this.ConvertBinaryToDecimal(numBaseConvert, number);
                        return result;
                    } else if (numBaseConvert == 16) {
                        result = this.ConvertBinaryToHexadecimal(numBaseConvert, number);
                        return result;
                    } else {
                        return "ERROR IN NUMBASECONVERT";
                    }
                case 10:
                    if (numBaseConvert == 2) {
                        result = this.ConvertDecimalToBinary(numBaseConvert, number);
                        return result;
                    } else if (numBaseConvert == 16) {
                        result = this.ConvertDecimalToHexadecimal(numBaseConvert, number);
                        return result;
                    } else {
                        return "ERROR IN NUMBASECONVERT";
                    }
                case 16:
                    if (numBaseConvert == 2) {
                        result = this.ConvertHexadecimalToBinary(numBaseConvert, number);
                        return result;
                    } else if (numBaseConvert == 10) {
                        result = this.ConvertHexadecimalToDecimal(numBaseConvert, number);
                        return result;
                    } else {
                        return "ERROR IN NUMBASECONVERT";
                    }
                default:
                    return "ERROR IN NUMBASE";
            }
        }

        // Binary to...

        private string ConvertBinaryToDecimal(int numBaseConvert, string number)
        {
            string response = Convert.ToInt32(number, 2).ToString();
            return response;
        }

        private string ConvertBinaryToHexadecimal(int numBaseConvert, string number)
        {
            int helper = Convert.ToInt32(number, 2);
            string response = Convert.ToString(helper, 16);

            return response.ToString();
        }

        // Decimal to...

        private string ConvertDecimalToBinary(int numBaseConvert, string number)
        {
            int dNumber = Convert.ToInt32(number);
            string response = Convert.ToString(dNumber, 2);
            return response;
        }

        private string ConvertDecimalToHexadecimal(int numBaseConvert, string number)
        {
            int dNumber = Convert.ToInt32(number);
            string response = Convert.ToString(dNumber, 16);
            return response;
        }

        // Hexadecimal to...
        private string ConvertHexadecimalToBinary(int numBaseConvert, string number)
        {
            string response = Convert.ToString(Convert.ToInt32(number.ToString(), 16), 2);
            return response;
        }

        private string ConvertHexadecimalToDecimal(int numBaseConvert, string number)
        {
            int response = int.Parse(number, System.Globalization.NumberStyles.HexNumber);
            return response.ToString();
        }
    }
}
