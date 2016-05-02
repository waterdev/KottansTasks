using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KottansTasks
{
    public static class KottansTasks
    {
        public static string GetCreditCardVendor(string cardNumber)
        {
            //Remove all whitespaces
            cardNumber = new string(cardNumber.Where(c => !char.IsWhiteSpace(c)).ToArray());

            //Create Regex check patterns
            Regex visaRgx = new Regex("^4[0-9]{6,}$");
            Regex masterCardRgx = new Regex("^5[1-5][0-9]{5,}$");
            Regex jcbRgx = new Regex("^(?:2131|1800|35[0-9]{3})[0-9]{3,}$");
            Regex americanExpressRgx = new Regex("^3[47][0-9]{5,}$");
            Regex maestroRgx = new Regex(@"(?:5018|5020|5038|5612|5893|6304|6759|6761|6762|6763|0604|6390)[0-9]{8,15}");

            //Check all patterns
            if (visaRgx.IsMatch(cardNumber))
                return "VISA";
            else if (masterCardRgx.IsMatch(cardNumber))
                return "MasterCard";
            else if (jcbRgx.IsMatch(cardNumber))
                return "JCB";
            else if (americanExpressRgx.IsMatch(cardNumber))
                return "AMERICAN EXPRESS";
            else if (maestroRgx.IsMatch(cardNumber))
                return "Maestro";


            return "Unknown";
        }



        public static bool IsCreditCardNumberValid(string cardNumber)
        {
            //check if all symbols are numbers
            cardNumber = new string(cardNumber.Where(x => Char.IsNumber(x)).Reverse().ToArray());

            //for every not even index  multiply symbol by 2
            int sumOfDigits = cardNumber
                    .Select((e, i) => ((int)e - '0') * (i % 2 == 0 ? 1 : 2)) //e-48 or -'0' is a cast to int 
                    .Sum((e) => e / 10 + e % 10);

            return sumOfDigits % 10 == 0;        
        }

        public static int GenerateNextCreditCardNumber(string cardNumber)
        {
            //check if all symbols are numbers
            cardNumber = new string(cardNumber.Where(x => Char.IsNumber(x)).Reverse().ToArray());

            //for every even index  multiply symbol by 2
            int sumOfDigits = cardNumber
                    .Select((e, i) => ((int)e - '0') * (i % 2 != 0 ? 1 : 2)) //e-48 or -'0' is a cast to int 
                    .Sum((e) => e / 10 + e % 10);

            //get the next number of checksum
            return (10 - (sumOfDigits % 10));
        }
    }
}
