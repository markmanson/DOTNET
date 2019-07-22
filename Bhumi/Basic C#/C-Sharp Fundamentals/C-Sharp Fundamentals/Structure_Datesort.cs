using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
///NameSpace:CSharp
/// Description://Fundamental study programs of C#
/// Author:bhumi
/// Created On:22/5/2015
/// </summary>
namespace CSharp
{
    #region Structure pass by value and reference
    class Structure_Datesort
    {
        List<DateTime> arraylistdate = new List<DateTime>();//Typed arraylist
        //structure for date    
        public struct Struct_Date
        {
            int dt1, mn1, yr1;
            public int Date//date
            {
                get
                {
                    return dt1;
                }
                set
                {
                    dt1 = value;
                }
            }
            public int Month//month
            {
                get
                {
                    return mn1;
                }
                set
                {
                    mn1 = value;
                }
            }
            public int Year//year
            {
                get
                {
                    return yr1;
                }
                set
                {
                    yr1 = value;
                }
            }
        }
        //variable declaration
        int dt2, mn2, yr2;
        //object creation
        ConstantMessage objconst;
        Struct_Date objstructdate;
        /// <summary>
        ///Method Name:Getdate_Struct
        /// Description://Create Structure to store date
        /// Author:bhumi
        /// Created On:26/5/2015
        /// </summary>               
        public void Getdate_Struct()
        {
            try
            {
                objstructdate = new Struct_Date();        
                objconst = new ConstantMessage();
                Console.WriteLine(objconst.strdate);
                dt2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(objconst.strmonth);
                mn2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(objconst.stryear);
                yr2 = Convert.ToInt32(Console.ReadLine());
                objstructdate.Date = dt2;
                objstructdate.Month = mn2;
                objstructdate.Year = yr2;
                DateTime dateTime = new DateTime(yr2, mn2, dt2);
                arraylistdate.Add(dateTime);                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(objconst.strinvalid);
                Getdate_Struct();
            }
        }
        public override string ToString()
        {
            //return base.ToString();
            return objstructdate.Date+"/"+objstructdate.Month+"/"+objstructdate.Year;              
        }
        /// <summary>
        ///Method Name:Print
        /// Description://Print the actual dates
        /// Author:bhumi
        /// Created On:26/5/2015
        /// </summary>               
        public void Print()
        {
            foreach (DateTime i in arraylistdate)
            {
                Console.WriteLine(i.ToShortDateString());
            }
            Console.WriteLine(objconst.strsortdatebyval);
            SortByValue(arraylistdate);
            Console.WriteLine(objconst.strsortdatebyref);
            SortByReference(ref arraylistdate);
        }
        /// <summary>
        ///Method Name:SortByValue
        /// Description://Print the sorted dates passing by value
        /// Author:bhumi
        /// Created On:26/5/2015
        /// </summary>               
        public void SortByValue(List<DateTime> arraylistdate)
        {
            foreach (var date in arraylistdate.OrderBy(x => x))
            {
                Console.WriteLine(date.ToShortDateString());
                arraylistdate = new List<DateTime>();

            }
        }
        /// <summary>
        ///Method Name:SortByReference
        /// Description://Print the sorted dates passing by reference
        /// Author:bhumi
        /// Created On:26/5/2015
        /// </summary>               
        public void SortByReference(ref List<DateTime> arraylistdate)
        {
            foreach (var date in arraylistdate.OrderBy(x => x))
            {
                Console.WriteLine(date.ToShortDateString());
                arraylistdate = new List<DateTime>();
            }
        }
    }
    #endregion
}
