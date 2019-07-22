using System;

namespace Program
{
    /*-------------------------------------------------------------------------------------------------------------------
    Name:CommonLogic.cs
    Author:Monal Shah
    Description:This Class is Contains all the common Logic of program. 
   
    CreatedDate: 2010/09/09 by Monal Shah
    -------------------------------------------------------------------------------------------------------------------
     */
    class CommonLogic
    {
        public int intDigCount = 0, intUpperCount = 0,intLowerCount = 0;
         //intDigCount is variable name of integer datatype initialized with 0.
         //intUpperCount is variable name of integer datatype initialized with 0.
        //intLowerCount is variable name of integer datatype initialized with 0.

        #region CheckDigitAndCharacters
        /// <summary>
        /// ---------------------------------------------------------------------------------------------------------------
         /*  Name:CheckDigitAndCharacters
           Paramametres:char[]
           Return: int
           Description:This method is used for checking the digit value which is enterd by user and produce result 
                        which contains the total number of digit in input.
           Author:Monal Shah
           CreatedDate: 2010/09/09 by Monal Shah
            ---------------------------------------------------------------------------------------------------------------
        */
        /// </summary>
        /// <param name="chChnDigit"></param>
        /// <param name="intIJK"></param>
        /// <returns></returns>
        public int CheckDigitAndCharacters(char[] chChnDigit,int intIJK)
        {
          /* In Below code digit will be checked if in input there is digit then intDigCount is increased else not.*/
                    if (intIJK == 0)
                    {
                        for (int intI = 0; intI < chChnDigit.Length; intI++)
                        {
                            if (char.IsDigit(chChnDigit[intI]) == true)
                            {
                                intDigCount++;//intDigCount is increased.
                            }
                        }
                        return intDigCount;  
                    }
                    if (intIJK == 1)
                    {
                         for (int intI = 0; intI < chChnDigit.Length; intI++)
                         {
                            if (char.IsUpper(chChnDigit[intI]) == true)
                            {
                                intUpperCount++;//intUpperCount is increased
                            }
                         }
                        return intUpperCount;    
                    }
                   if (intIJK == 2)
                    {
                        for (int intI = 0; intI < chChnDigit.Length; intI++)
                        {
                            if (char.IsLower(chChnDigit[intI]) == true)
                             {
                                 intLowerCount++;//intUpperCount is increased
                            }
                        }
                        return intLowerCount;
                    }
                   return 1; 
            }
           
        
        #endregion
        #region ValidateDate
        /// <summary>
        /// ---------------------------------------------------------------------------------------------------------------
        /*  Name:ValidateDate
          Paramametres:string
          Return: bool
          Description:Validate the date format
          Author:Monal Shah
          CreatedDate: 2010/09/10 by Monal Shah
      ---------------------------------------------------------------------------------------------------------------
      */
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool ValidateDate(string strDate)
        {
            if (strDate != null)
            {
                    string[] strDateParts = strDate.Split('/');
                    DateTime testDate = new DateTime
                                        (Convert.ToInt32(strDateParts[2].Substring(0, 4)),
                                         Convert.ToInt32(strDateParts[0]),
                                         Convert.ToInt32(strDateParts[1]));


                    return true;
            }
            else 
            {
                try
                {
                    return false;
                }
                catch (NullReferenceException exNullException)
                {
                    Console.WriteLine("Please Enter Value Propery:" + exNullException.Message);
                }
            }
            return false;
        }        
        #endregion
        #region SortByRef
        /// <summary>
        /// name:SortByRef
        /// returntype:struct
        /// Descrption:Dates will be sorted by passing refernce of structure's object 
        /// AuthorName:Monal Shah
        /// CreatedDate:2010/09/15
        /// </summary>
        /// <param name="structDates"></param>
        /// <returns></returns>
        public DateStructFormats1[] SortByRef(ref DateStructFormats1[] structDates)
        {
                             //SortedList<DateTime, int> sort1 = new SortedList<DateTime, int>();
            DateTime[] dtDate = new DateTime[structDates.Length];//dtdate off array is created with structure's object length 
            DateTime dtDate1; 
            string[] strS;//strS is object of string 
           
          
                for (int intJ = 0; intJ < structDates.Length; intJ++)
                {
                    dtDate[intJ] = Convert.ToDateTime
                                  (structDates[intJ].ToString());//here structDates is converted into datetime
                    // sort1.Add(date[intJ], intJ);
                }
                for (int intI = 0; intI < structDates.Length - 1; intI++)
                {

                    for (int intJ = intI + 1; intJ < structDates.Length; intJ++)
                    {
                        // if First date is greater than second date than swapping is done and small date is position of one and greater date in second position.
                        if (DateTime.Compare(dtDate[intI], dtDate[intJ]) > 0)
                        {
                            dtDate1 = dtDate[intI];
                            dtDate[intI] = dtDate[intJ];
                            dtDate[intJ] = dtDate1;
                            //sort1.Add(date[intI], intI);
                            //bolSwap = true;

                        }
                    }
                } // }

                //foreach (DateTime date2 in date)
                //{
                //    s = date2.ToString().Split('/');
                //    structDates[intK] = new DateStructFormats1(Convert.ToInt32(s[1]), Convert.ToInt32(s[0]), Convert.ToInt32(s[2].Substring(0, 4)));
                //    intK++;


                //}
                Console.WriteLine("Sorted Dates\n");
                for (int intI = 0; intI < structDates.Length; intI++)
                {
                    strS = dtDate[intI].ToString().Split('/');//Split the datetime's value by "/" and stored in strS
                    structDates[intI] = new DateStructFormats1
                                        (Convert.ToInt32(strS[1]),
                                        Convert.ToInt32(strS[0]),
                                        Convert.ToInt32(strS[2].Substring(0, 4)));//take the value of dates into structDates
                    Console.WriteLine("Sorted date:" + structDates[intI].ToString());
                }
                return structDates;
            
           
        }
        #endregion
        #region SortByValue
        /// <summary>
        /// name:SortByRef
        /// returntype:struct
        /// Descrption:Dates will be sorted by passing value of structure's object 
        /// AuthorName:Monal Shah
        /// CreatedDate:2010/09/15
        /// </summary>
        /// <param name="structDates1"></param>
        /// <returns></returns>
        public DateStructFormats1[] SortByValue(DateStructFormats1[] structDates1)
        {
          //  SortedList<DateTime, int> sort2 = new SortedList<DateTime, int>();
            DateTime[] dtDate = new DateTime[structDates1.Length];//dtdate off array is created with structure's object length 
            DateTime dtDate1;
            string[] strS;//strS is object of string 
           
                for (int intJ = 0; intJ < structDates1.Length; intJ++)
                {
                    dtDate[intJ] = System.Convert.ToDateTime
                                   (structDates1[intJ].ToString());//here structDates is converted into datetime
                    // sort1.Add(date[intJ], intJ);
                }
                for (int intI = 0; intI < structDates1.Length - 1; intI++)
                {

                    for (int intJ = intI + 1; intJ < structDates1.Length; intJ++)
                    {
                        // if First date is greater than second date than swapping is done and small date is position of one and greater date in second position.
                        if (DateTime.Compare(dtDate[intI], dtDate[intJ]) > 0)
                        {
                            dtDate1 = dtDate[intI];
                            dtDate[intI] = dtDate[intJ];
                            dtDate[intJ] = dtDate1;
                            //sort1.Add(date[intI], intI);
                            //bolSwap = true;

                        }
                    }
                }
                Console.WriteLine("Sorted Dates\n");
                for (int intI = 0; intI < structDates1.Length; intI++)
                {
                    strS = dtDate[intI].ToString().Split('/');//Split the datetime's value by "/" and stored in strS
                    structDates1[intI] = new DateStructFormats1
                                        (Convert.ToInt32(strS[1]),
                                         Convert.ToInt32(strS[0]),
                                         Convert.ToInt32(strS[2].Substring(0, 4)));//take the value of dates into structDates
                    Console.WriteLine("Sorted date:"
                                       + structDates1[intI].ToString());
                }
                return structDates1;
            
         
            //foreach (DateTime date1 in sort2.Keys)
            //{
            //    s = date1.ToString().Split('/');
            //    structDates1[intK] = new DateStructFormats1(Convert.ToInt32(s[0]), Convert.ToInt32(s[1]), Convert.ToInt32(s[2].Substring(0, 4)));
            //    intK++;
            //}
            
            
           
        #endregion

        }
        
       

           
    }
    
}
