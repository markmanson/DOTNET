using System;
namespace ConsoleApplication3
{
    #region ShowWords
    //Name                      : ShowWords
    //Auther                    : Ankit Sharma
    //Created Date              : 04/07/2012
    //Description               : To show an ammount into words    
    class ShowWords
    {
        #region NumberToWords
        //Function to convert an ammount to words ***************************************************************************
        public  string NumberToWords(int number)
        {
            if (number == 0)                                                //Check if number is zero
                return "zero";
            if (number < 0)                                                 //Check if number is less than zero
                return "minus " + NumberToWords(Math.Abs(number));
            string words = "";
            if ((number / 10000000) > 0)                                     //Check if number is in crore range                  
            {
                words += NumberToWords(number / 10000000) + " crore ";
                number %= 10000000;
            }
            if ((number / 100000) > 0)                                      //Check if number is in lac range
            {
                words += NumberToWords(number / 100000) + "lac ";            
                number %= 100000;
            }
            if ((number / 1000) > 0)                                         //Check if number is in thousand range
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }
            if ((number / 100) > 0)                                          //Check if number is in hundred range
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }
            if (number > 0)                                                 //check for 1 to ninty nine
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)                                            //Check if number is 1 to 19
                    words += unitsMap[number];
                else                                                        //check if number is 10.20.30 etc
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }
            return words;
        }
        #endregion NumberToWords        
    }
    #endregion ShowWords
}

