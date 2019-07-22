using System;

namespace Basic_C_Sharp
{
    #region
    //NAME          :- StringBldr
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- Enter number and print in words 
    //CREATED DATE  :- 17/07/2012

    class StringBldr
    {
        //NAME          :- NumToWrds
        //AUTHOR        :- SHIKHA MALIK
        //DESCRIPTION   :- Enter number and print in words 
        //CREATED DATE  :- 17/07/2012


        public string NumToWrds(int intNum)
        {
            if (intNum == 0)                                                       //Check if number is zero
                return "zero";
            if (intNum < 0)                                                 //Check if intNum is less than zero
                return "minus " + NumToWrds(Math.Abs(intNum));
            string strWrds = "";
            if ((intNum / 10000000) > 0)                                       //Check if intNum is in crore range                  
            {
                strWrds += NumToWrds(intNum / 10000000) + " crore ";
                intNum %= 10000000;
            }
            if ((intNum / 100000) > 0)                                          //Check if intNum is in lac range
            {
                strWrds += NumToWrds(intNum / 100000) + "lac ";
                intNum %= 100000;
            }
            if ((intNum / 1000) > 0)                                       //Check if intNum is in thousand range
            {
                strWrds += NumToWrds(intNum / 1000) + " thousand ";
                intNum %= 1000;
            }
            if ((intNum / 100) > 0)                                          //Check if intNum is in hundred range
            {
                strWrds += NumToWrds(intNum / 100) + " hundred ";
                intNum %= 100;
            }
            if (intNum > 0)                                                //check for 1 to ninty nine
            {
                if (strWrds != "")
                    strWrds += "and"+" ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (intNum < 20)                                            //Check if intNum is 1 to 19
                    strWrds += unitsMap[intNum];
                else                                                        //check if intNum is 10.20.30 etc
                {
                    strWrds += tensMap[intNum / 10];
                    if ((intNum % 10) > 0)
                        strWrds += "-" + unitsMap[intNum % 10];
                }
            }
            return strWrds;
        }

    }
    #endregion
}
