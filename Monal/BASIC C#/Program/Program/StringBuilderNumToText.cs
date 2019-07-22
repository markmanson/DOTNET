using System;

namespace Program
{
    class StringBuilderNumToText
    {
        /*--------------------------------------------------------------------------------------------------------------------
        Name:StringBuilderNumberToText.cs
        Author:Monal Shah
        Description:"Accept an amount from user. 
                     Print the amount in words using a StringBuilder class."
        
        CreatedDate: 2010/09/10 by Monal Shah
-------------------------------------------------------------------------------------------------------------------
*/
      
            #region StrngBuilderNumtoText

            /// <summary>
            /// Name:StrngBuilderNumtoText
            /// Author:Monal Shah
            /// CreatedDate:2010/09/10
            /// Description:this method is used to convert the amount into the words.
            /// </summary>
            /// <param name="number"></param>
            /// <returns></returns>

        public string StrngBuilderNumtoText(int intNumber)
        {
            int[] intNum = new int[4];
            int intFirst = 0;
            int intUnit;
            int intHundred;
            int intThousand;
            
                System.Text.StringBuilder sbAmount = new System.Text.StringBuilder();
                //if intNumber is equal to 0 then it return 0
                if (intNumber == 0)
                {
                    return "Zero";
                }
              
                /*if intNumber is < 0 then in sbamount minus will be append*/
                if (intNumber < 0)
                {
                    sbAmount.Append("Minus ");
                    intNumber = -intNumber;
                }
                string[] strWords0 = {"" ,"One ", "Two ", "Three ", "Four",
                                 "Five " ,"Six ", "Seven ", "Eight ", "Nine "};
                string[] strWords1 = {"Ten ", "Eleven ", "Twelve ", "Thirteen ",
                                      "Fourteen ","Fifteen ","Sixteen ",
                                      "Seventeen ","Eighteen ", "Nineteen "};
                string[] strWords2 = {"Twenty ", "Thirty ", "Forty ",
                                       "Fifty ", "Sixty ","Seventy ","Eighty ",
                                       "Ninety "};
                string[] strWords3 = { "Thousand ", "Lakh ", "Crore " };
                intNum[0] = intNumber % 1000; // units 
                intNum[1] = intNumber / 1000;
                intNum[2] = intNumber / 100000;
                intNum[1] = intNum[1] - 100 * intNum[2]; // thousands 
                intNum[3] = intNumber / 10000000; // crores 
                intNum[2] = intNum[2] - 100 * intNum[3]; // lakhs
                for (int intI = 3; intI > 0; intI--)
                {
                    /*if intNum[intI] is not 0 the intI value is going into intFirst*/
                    if (intNum[intI] != 0)
                    {
                        intFirst = intI;
                        break;
                    }
                }
                for (int intI = intFirst; intI >= 0; intI--)
                {
                    if (intNum[intI] == 0) continue;
                    intUnit = intNum[intI] % 10; // ones
                    intThousand = intNum[intI] / 10;
                    intHundred = intNum[intI] / 100; // hundreds 
                    intThousand = intThousand - 10 * intHundred; // tens 
                    /*if intHundred is > 0 then in sbamount Hundred will be append*/
                    if (intHundred > 0)
                    {
                        sbAmount.Append(strWords0[intHundred] + "Hundred ");
                    }
                    /*if intUnit is > 0  or intThosand>0 then
                     * if intHundred > 0 or intI = 0 then in sbamount and will be append
                     * if intThousand = 0 then in sbamount strwords0's value will be append 
                     *      else if intthosand=1 then in sbamount strwords1's value will be append
                     *      else in sbamount strwords2[intThousand - 2] + strWords0[intUnit]'s value will be append
                     *
                     */
                    if (intUnit > 0 || intThousand > 0)
                    {
                        if (intHundred > 0 || intI == 0)
                        {
                            sbAmount.Append("and ");
                        }
                        if (intThousand == 0)
                        {
                            sbAmount.Append(strWords0[intUnit]);
                        }
                        else if (intThousand == 1)
                        {
                            sbAmount.Append(strWords1[intUnit]);
                        }
                        else
                        {
                            sbAmount.Append(strWords2[intThousand - 2] + strWords0[intUnit]);
                        }
                    }
                    /*if intI != 0 then in sbamount strwords3[intI-1]'s value will be append*/
                    if (intI != 0)
                    {
                        sbAmount.Append(strWords3[intI - 1]);
                    }
                }
                return sbAmount.ToString().TrimEnd();
            
         
            #endregion
        }
     }
}
