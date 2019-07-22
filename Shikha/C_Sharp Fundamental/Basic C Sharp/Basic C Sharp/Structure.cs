using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic_C_Sharp
{
    struct Structure
    {
        int intDay, intMonth, intYear;
        public int Day
        {
            get
            {
                return intDay;
            }
            set
            {
                intDay = value;
            }
        }
        public int Month
        {
            get
            {
                return intMonth;
            }
            set
            {
                intMonth = value;
            }
        }
        public int Year
        {
            get
            {
                return intYear;
            }
            set
            {
                intYear = value;
            }
        }
        public string Display()
        {
            int intcount;
            try
            {
                Console.WriteLine("Please Enter date");
                intDay = int.Parse(Console.ReadLine());
                if (intDay >= 1 && intDay <= 31)
                {
                    Console.WriteLine("Day is" + intDay);
                    return str;
                }

                else if (intMonth >= 1 && intMonth <= 12)
                {
                    Console.WriteLine("Month is" + intMonth);
                    return;
                }

                else if (intYear >= 1000 && intYear <= 9999)
                {
                    Console.WriteLine("Year is" + intYear);
                    return;
                }
                else
                {
                    Console.WriteLine("Value is not valid");
                }
 string strDate=Convert.ToString( intDay) + "/" + Convert.ToString( intMonth) + "/" + Convert.ToString(intYear);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            }

        }
    }
}
