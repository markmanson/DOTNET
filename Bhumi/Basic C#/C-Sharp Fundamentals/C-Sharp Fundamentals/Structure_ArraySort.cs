using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
///NameSpace:CSharp
/// Description://Fundamental study programs of C#
/// Author:bhumi
/// Created On:22/5/2015
/// </summary>
namespace CSharp
{
    /// <summary>
    /// Class Name:Structure_ArraySort
    ///             Description:Create an array of the date structures created above.  
    ///             Pass this array by value to a sort routine.  
    ///             Pass the array by ref to a sort routine. 
    ///             Print the original and sorted arrays from outside the sort routine.
    /// Author:bhumi
    /// Created On:22/5/2015
    /// </summary>
    class Structure_ArraySort
    {
        #region Sorting of Date using structure
        //Create Structure
        public struct Str_Date
        {
            public int Dt;
            public int mn;
            public int yr;
        };

        int dt1, mn1, yr1;
        int dt2, mn2, yr2;
        string input1, input2;
        DateTime datetime1,datetime2;                
        ConstantMessage objconst; //object creation
        /// <summary>
        ///Method Name:DateSort
        /// Description://Create Structure & sort the dates
        /// Author:bhumi
        /// Created On:25/5/2015
        /// </summary>
        public void DateSort()
        {
            try
            {
                objconst = new ConstantMessage();
                //Pass by value
                Console.WriteLine(objconst.strdate);
                dt1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(objconst.strmonth);
                mn1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(objconst.stryear);
                yr1 = Convert.ToInt32(Console.ReadLine());

                Str_Date structdate;
                structdate.Dt = dt1;
                structdate.mn = mn1;
                structdate.yr = yr1;
                SetDate(structdate);

                //Pass by reference
                Console.WriteLine(objconst.strdate);
                dt2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(objconst.strmonth);
                mn2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(objconst.stryear);
                yr2 = Convert.ToInt32(Console.ReadLine());
                SetDate(ref structdate);
                input1 = dt1 + "-" + mn1 + "-" + yr1;
                input2 = dt2 + "-" + mn2 + "-" + yr2;
                //Original dates
                if(DateTime.TryParse(input1,out datetime1) && DateTime.TryParse(input2,out datetime2))
                {
                    Console.WriteLine(objconst.stractualdate);
                    Console.WriteLine(input1);
                    Console.WriteLine(input2);
                    //SORT the DATES
                    Console.WriteLine(objconst.strsortdate);
                    List<string> dates = new List<string>() { dt1 + "-" + mn1 + "-" + yr1, dt2 + "-" + mn2 + "-" + yr2 };
                    foreach (var date in dates.OrderBy(x => x))
                    {
                        Console.WriteLine(date);
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        ///Method Name:SetDate
        /// Description://pass by value in structure
        /// Author:bhumi
        /// Created On:25/5/2015
        /// </summary>
        void SetDate(Str_Date s1)
        {
            try
            {
                s1.Dt = dt1;
                s1.mn = mn1;
                s1.yr = yr1;
                string input = s1.Dt + "/" + s1.mn + "/" + s1.yr;
                DateTime dateTime;
                if (DateTime.TryParse(input, out dateTime))
                {

                }
                else
                {
                    Console.WriteLine(objconst.strinvalid); // <-- Control flow goes here                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
        /// <summary>
        ///Method Name:SetDate
        /// Description://pass by reference in structure
        /// Author:bhumi
        /// Created On:25/5/2015
        /// </summary>
        void SetDate(ref Str_Date s1)
        {
            
            s1.Dt = dt2;
            s1.mn = mn2;
            s1.yr = yr2;

            string input = s1.Dt + "-" + s1.mn + "-" + s1.yr;
            DateTime dateTime;
            if (DateTime.TryParse(input, out dateTime))
            {
                
            }
            else
            {
                Console.WriteLine(objconst.strinvalid); // <-- Control flow goes here 
            }
        }         
        #endregion
    }
}
