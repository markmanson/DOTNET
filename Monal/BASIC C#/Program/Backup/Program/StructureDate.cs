using System;

namespace Program
{
    
    #region DateFormats
        /// <summary>
        /// Name:DateFormats
        /// Description:Create structure to store dates (separate fields for dd, mm and yyyy).
        /// Author:Monal Shah
        /// CreatedDate:2010/09/10
        /// </summary>
        public struct DateFormats
        {

            public int _intDate;
            public int _intMonth;
            public int _intYear;

            public int Date
            {
                get
                {
                    return _intDate;
                }
                set
                {

                    _intDate = value;
                }
            }
            public int Month
            {
                get
                {
                    return _intMonth;
                }
                set
                {

                    _intMonth = value;
                }
            }
            public int Year
            {
                get
                {
                    return _intYear;
                }
                set
                {

                    _intYear = value;
                }
            }
            public DateFormats(int intDt, int intMnth, int intYer)
            {
                _intDate = intDt;
                _intMonth = intMnth;
                _intYear = intYer;
            }
            public override string ToString()
            {
                return string.Format("{0}/{1}/{2}", _intDate.ToString(),
                                _intMonth.ToString(), _intYear.ToString());
            }
        };
        #endregion
        /*--------------------------------------------------------------------------------------------------------------------
         Name:StructureDate.cs
         Author:Monal Shah
         Description:Create structure to store dates (separate fields for dd, mm and yyyy).
                     Write code to accept each value from the user and validate and print the date.

         CreatedDate: 2010/09/10 by Monal Shah
        -------------------------------------------------------------------------------------------------------------------
         */
    class StructureDate
    {
        #region StructDates
        /// <summary>
        /// Name:StructDates
        /// Description:code to accept each value from the user and validate and print the date.
        /// Author:Monal Shah
        /// CreatedDate:2010/09/10
        /// </summary>
        public void StructDates()
        {
            Console.WriteLine("How Many Dates you want to enter:");
            int intNumber = System.Convert.ToInt32(Console.ReadLine());
            DateFormats[] dteTotal = new DateFormats[intNumber];//create the object of Structure with intNumber Size
            string dteTotal1;
            int intDteDate, intDteMnth, intDteYre;
            CommonLogic objClDate = new CommonLogic();//CommonLogic Object is created
            try
            {
                Console.WriteLine("Please Enter First DayValue Second+"  
                                   +"MonthValue and Third YearValue");

                for (int intI = 0; intI < dteTotal.Length; intI++)
                {
                    Console.WriteLine("Please Enter Day");
                    intDteDate = System.Convert.ToInt32(Console.ReadLine());//accepting value from the console
                    Console.WriteLine("Please Enter Month");
                    intDteMnth = System.Convert.ToInt32(Console.ReadLine()); //accepting value from the console
                    Console.WriteLine("Please Enter Year");
                    intDteYre = System.Convert.ToInt32(Console.ReadLine());//accepting value from the console
                    dteTotal[intI] = new DateFormats
                        (intDteDate, intDteMnth, intDteYre);//structure object is created and pass the parameters
                    dteTotal1 = dteTotal[intI].ToString();//Convert into tostring format
                    bool bolflag=objClDate.ValidateDate(dteTotal1);//ValidateDate method is called by commonlogic object
                    if (bolflag)
                    {
                        Console.WriteLine("Date Format is in DD/MM/YYYY");
                        Console.WriteLine("Valid date Format:" + dteTotal1);
                    }
                    else
                    {
                        Console.WriteLine("Enter valid Date value ");
                    }
                  }
            }
            catch (Exception ExException)
            {
                Console.WriteLine("ERROR:" + ExException.Message);//exception
            }
            finally
            {
                dteTotal1 = null;
                objClDate = null;
                dteTotal = null;
            }
        }
        #endregion
        
    }
}
