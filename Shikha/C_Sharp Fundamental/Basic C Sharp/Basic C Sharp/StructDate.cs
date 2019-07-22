using System;

namespace Basic_C_Sharp
{
    #region
    //NAME          :- StructDate
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- Property for store date
    //CREATED DATE  :- 18/07/2012  

  public  struct StructDate
    {
       public  int intDay, intMonth, intYear;
       public int Day                                      //property for get and set value of Day , month, year
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

        //NAME          :- dateArray
        //AUTHOR        :- SHIKHA MALIK
        //DESCRIPTION   :- Display Date 
        //CREATED DATE  :- 18/07/2012 

        public string dateArray()
        {
           DateTime objDateTime;
           try
           {
               Console.WriteLine(Constant.strEntrDay);            //Enter day
               Day = int.Parse(Console.ReadLine());
               Console.WriteLine(Constant.strEntrMonth);         // Enter Month
               Month = int.Parse(Console.ReadLine());
               Console.WriteLine(Constant.strEntrYear);          // Enter Year
               Year = int.Parse(Console.ReadLine());

               objDateTime = new DateTime( intYear ,intMonth , intDay); //create object for dateTime class, date time apply all validation on date
               DateTime objOnlyDate = objDateTime.Date;                
               if (intYear < 1000 || intYear > 9999)                    // validation for enter year           
               {
                   Console.WriteLine("invalid");
               }
               Console.WriteLine(intDay + "/" + intMonth + "/" + intYear);       // print date in formate
               return "";
           }
           catch (Exception)
           {
               Console.WriteLine("Ivnalid input");                            // throw exception
               return "";
           }


        }
    }
    #endregion
}
      
          



