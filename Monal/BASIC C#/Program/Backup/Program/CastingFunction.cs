using System;

namespace Program
{
    /*--------------------------------------------------------------------------------------------------------------
        Name:CastingFunction.cs
        Author:Monal Shah
        Description:""Accept a double value from user.  Print its integer part through:
                    - Casting - Rounding off - Manually"

        CreatedDate: 2010/09/09 by Monal Shah
-------------------------------------------------------------------------------------------------------------------
*/
    class CastingFunction
    {
        #region
        /// <summary>
        /// Name:CastingValue
        /// AuthorName:Monal Shah
        /// Descrption:
        /// CreatedDate:2010/09/09
        /// </summary>
        public void CastingValue()
        {
            string strText;
          //  decimal decValue;
            double dblValue;
            try
            {
                Console.WriteLine("Please Enter double value:");
                strText = Console.ReadLine();
                string[] strary = strText.Split('.');
                string strLeftValue=strary[0];
                string strRightValue=strary[1];
                int intRightValue = Convert.ToInt32(strRightValue.Substring 
                                    (0, 1));
                dblValue = System.Convert.ToDouble(strText);
                int intDblValue = (int)dblValue;
                int intManually = System.Convert.ToInt32(dblValue);
                int intRoundOff = (int)Math.Round(dblValue);
                int intIncrement = System.Convert.ToInt32(strLeftValue);
                Console.WriteLine("integer roundOff value using Rounding function:" 
                                  + intRoundOff);
                if (intRightValue >= 5)
                {                                                   
                    intDblValue++;
                    Console.WriteLine("integer value using casting function:" 
                                   + intDblValue);
                    Console.WriteLine("integer value manualy using convert function:" 
                                   + intManually);
                    intIncrement++;
                    Console.WriteLine("integer roundingoff value Manually:" 
                                    + intIncrement);

                }
                else if (intRightValue < 5)
                {
                    int intSameValue = System.Convert.ToInt32(strLeftValue);
                    Console.WriteLine("integer value using casting function:" 
                                    + intSameValue);
                    Console.WriteLine("integer value manualy using convert function:"
                                    + intSameValue);
                    Console.WriteLine("integer roundingoff value Manually:" 
                                    + intSameValue);
                }
              Console.ReadLine();
                //if (decimal.TryParse(strText, out decValue))
                //{
                //    decValue = Math.Round(decValue);
                //    strText = decValue.ToString();
                //    Console.WriteLine(strText);
                //}
            }
            catch (Exception exException)
            {
                Console.WriteLine("Error:" + exException.Message);
            }
            finally
            {
                strText = null;
            }
        }
        #endregion
    }
}
