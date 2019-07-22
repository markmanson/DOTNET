using System;
using System.Collections;
using System.Collections.Generic;

namespace Program
{
  
    #region DateStructFormats1
    /// <summary>
    /// Name:DateFormats1
    /// Description:Create structure to store dates (separate fields for dd, mm and yyyy).
    /// Author:Monal Shah
    /// CreatedDate:2010/09/10
    /// </summary>
    public struct DateStructFormats1
    {

        public int intDates;
        public int intMonths;
        public int intYears;

        public int Date
        {
            get { return intDates; }
            set { intDates = value; }
        }
        public int Month
        {
            get { return intMonths; }
            set { intMonths = value; }
        }
        public int Year
        {
            get { return intYears; }
            set { intYears = value; }
        }
        public DateStructFormats1(int intDt, int intMnth, int intYer)
        {
            intDates = intDt;
            intMonths = intMnth;
            intYears = intYer;
        }
        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", intDates.ToString(), intMonths.ToString(), intYears.ToString());
        }
    };
    #endregion
    /*--------------------------------------------------------------------------------------------------------------------
        Name:StructureDateSort.cs
        Author:Monal Shah
        Description:Create an array of the date structures created on StructDate Program.
                      Pass this array by value to a sort routine.
                      Pass the array by ref to a sort routine. 
                      Print the original and sorted arrays from outside the sort routine.
        CreatedDate: 2010/09/10 by Monal Shah
-------------------------------------------------------------------------------------------------------------------
*/
    class StructureDateSort
    {
        List<string> lsDate = new List<string>();

        #region StructDateSort
        /// <summary>
        /// Name:StructDateSort
        /// Author:monal shah
        /// CreatedDate:2010/09/15
        /// </summary>
        public void StructDateSort()
        {
            Console.WriteLine("How Many Dates you want to enter:");
            int intNumber = System.Convert.ToInt32(Console.ReadLine());//get the value from the console
            ArrayList arylist = new ArrayList();//create list object of arraylist
            DateStructFormats1[] dtStructFormat;//create the object of Structure 
            string strTotal1 = "";
            DateStructFormats1[] objDtTotal1;//create the object of Structure
            string[] strSplit;//create the array of String
            CommonLogic objClDate = new CommonLogic();//CommonLogic Object is created
            int intday = 0;
            int intMonth = 0;
            int intYear = 0;
            bool bolFlg;
            dtStructFormat = new DateStructFormats1[intNumber];//create the object of Structure with size of intNumber
            try
            {
                Console.WriteLine("Please Enter First DayValue Second MonthValue and Third YearValue");
                Console.WriteLine("\n");
                for (int intI = 0; intI < intNumber; intI++)
                {

                    Console.WriteLine("Please Enter Day");
                    intday = System.Convert.ToInt32(Console.ReadLine());//accepting value from the console
                    Console.WriteLine("Please Enter Month");
                    intMonth = System.Convert.ToInt32(Console.ReadLine());//accepting value from the console
                    Console.WriteLine("Please Enter Year");
                    intYear = System.Convert.ToInt32(Console.ReadLine());//accepting value from the console
                    dtStructFormat[intI] = new DateStructFormats1
                                            (intday, intMonth, intYear);
                    arylist.Add(dtStructFormat[intI]);//add value of dtstructFormat into ArrayList's object
                    strTotal1 = dtStructFormat[intI].ToString();//Convert into tostring format
                    bolFlg = objClDate.ValidateDate(strTotal1);//ValidateDate method is called by commonlogic object
                    //if bolFlag is true then date will be printed in valid format and add that date into list's object else print message Enter valid Date value
                    if (bolFlg)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Valid date Format:" + strTotal1);
                        lsDate.Add(strTotal1);
                    }
                    else
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Enter valid Date value ");
                    }

                }
                if (lsDate.Count>0)
                {
                    objDtTotal1 = new DateStructFormats1[lsDate.Count];//craete DateStructFormats1's object objDtTotal1 with size of List's object count  
                    for (int intI = 0; intI < lsDate.Count; intI++)
                    {
                        strSplit = lsDate[intI].ToString().Split('/');//Split the list's value by "/" and stored in strSplit
                        objDtTotal1[intI] = new DateStructFormats1
                                            (Convert.ToInt32(strSplit[1]),
                                             Convert.ToInt32(strSplit[0]),
                                             Convert.ToInt32(strSplit[2]));//take the value of dates into objDtTotal1 
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("Original dates in MM/DD/YYYY Format");
                    for (int intJ = 0; intJ < lsDate.Count; intJ++)
                    {
                        Console.WriteLine("Dates:" + objDtTotal1[intJ]);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("Traverse Format");
                    Console.WriteLine("\n");
                    Console.WriteLine("Sort by Reference");
                    objClDate.SortByRef(ref objDtTotal1);//here sortByRef is called from commonlogic class with reference of objDtTotal1
                    Console.WriteLine("\n");
                    Console.WriteLine("Traverse Format");
                    Console.WriteLine("\n");
                    Console.WriteLine("Sort by Value");
                    objClDate.SortByValue(objDtTotal1);//here sortByRef is called from commonlogic class with reference of objDtTotal1
                    Console.WriteLine("\n");
                }
            }

            catch (Exception ExException)
            {
                Console.WriteLine("ERROR:" + ExException.Message);//exception
            }
            finally
            {
                lsDate = null;
                arylist = null;
                dtStructFormat = null;
                objDtTotal1 = null;
                strSplit = null;
                objClDate = null;
            }
        }
        #endregion

    }
}
