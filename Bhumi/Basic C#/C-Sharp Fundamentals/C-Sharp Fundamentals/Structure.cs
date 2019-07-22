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
    /// <summary>
    /// Class Name:Structure
    /// Description://Create structure to store dates (separate fields for dd, mm and yyyy).              
    /// Author:bhumi
    /// Created On:21/5/2015
    /// </summary>
    class Structure
    {
        #region Use of Structure
        //Create Structure
        struct Str_Date
        {
            public int Dt;
            public int mn;
            public int yr;
        };
        ConstantMessage objconst; //object creation
        /// <summary>
        ///Method Name:GetDate
        /// Description://Create Structure to store date
        /// Author:bhumi
        /// Created On:22/5/2015
        /// </summary>
        public void GetDate()
        {
            List<DateTime> arraylistdate = new List<DateTime>();//Typed arraylist                
            try
            {
                Str_Date s1;
                int dt1, mn1, yr1;
                objconst = new ConstantMessage();
                Console.WriteLine(objconst.strdate);
                dt1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(objconst.strmonth);
                mn1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(objconst.stryear);
                yr1 = Convert.ToInt32(Console.ReadLine());
                s1.Dt = dt1;
                s1.mn = mn1;
                s1.yr = yr1;
                // Use DateTime.TryParse when input is valid.
                string input = s1.Dt + "-" + s1.mn + "-" + s1.yr;
                DateTime dateTime = new DateTime(yr1, mn1, dt1);
                arraylistdate.Add(dateTime);
                foreach (DateTime i in arraylistdate)
                {
                    Console.WriteLine(i.ToShortDateString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(objconst.strinvalid);
                GetDate();
            }
            finally
            {
                objconst = null;                
            }
        }
        #endregion
    }
}
