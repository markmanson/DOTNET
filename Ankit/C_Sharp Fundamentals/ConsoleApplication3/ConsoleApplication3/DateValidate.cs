using System;
namespace ConsoleApplication3
{
    #region DateValidate
    //Name                      : DateValidate
    //Auther                    : Ankit Sharma
    //Created Date              : 04/07/2012
    //Description               : To take the date from user and validate that      
    struct DateValidate
    {
        public int intDay, intMonth, intYear,intFlag;
        public override string ToString()
        {
            //DateValidate dt = new DateValidate();
            string Date = Convert.ToString(intDay) + "/" + Convert.ToString(intMonth) + "/" + Convert.ToString(intYear);
            return Date;
        }
        #region valid
        //Function to validate the date ************************************************************************
        public Boolean valid()
        {
            intFlag = 0;
            Console.WriteLine(Constant.strMsgEntrday);
            intDay = int.Parse(Console.ReadLine());                         //Input the day
            Console.WriteLine(Constant.strMsgEntrMnth);
            intMonth = int.Parse(Console.ReadLine());                       //Input the month
            Console.WriteLine(Constant.strMsgEntrYear);
            intYear=int.Parse(Console.ReadLine());                          //Input the year
            Console.WriteLine("you entered :-");
            Console.WriteLine(intDay + "-" + intMonth + "-" + intYear);     //Display the date entered by the user
            if (intYear > 999 && intYear < 3000)                            //Check if year in between 1000 and 2999
            {
                if (intMonth > 0 && intMonth < 13)                          //Check if month in between 1 to 12
                {
                    if (intYear % 4 == 0)                                   //Check if LEAP year
                    {
                        if (intMonth == 2 && intDay > 29)                   //Check feb should have max 29 days in a leap year 
                        {
                            Console.WriteLine(Constant.strMsgNotDate);
                            return false;
                        }
                        else if ((intMonth==4 ||intMonth == 6 || intMonth == 9 || intMonth == 11) && (intDay > 30))     //Check apr,jun,sept,nov should not have more than 30 days
                        {
                            Console.WriteLine(Constant.strMsgNotDate);
                            return false;
                        }
                        else if (intDay > 31)                               //Check no month can not have more than 31 days
                        {
                            Console.WriteLine(Constant.strMsgNotDate);
                            return false;
                        }
                        else                                                //If all are valid
                        {
                            Console.WriteLine(Constant.strMsgValidDate);
                            intFlag++;
                            return true;
                        }
                    }
                    else                                                    //If year is not a leap year
                    {
                        if (intMonth == 2 && intDay > 28)                   //Check feb can not have more than 28 days
                        {
                            Console.WriteLine(Constant.strMsgNotDate);
                            return false;
                        }
                        else if ((intMonth == 6 || intMonth == 9 || intMonth == 11) && (intDay > 30))//check for apr,jun, sept and november 
                        {
                            Console.WriteLine(Constant.strMsgNotDate);          //Display messege if date is not valid
                            return false;
                        }
                        else if (intDay > 31)                               //Check day should not more than 31                                        
                        {
                            Console.WriteLine(Constant.strMsgNotDate);
                            return false;
                        }
                        else                                                //Ifd date is valid
                        {
                            Console.WriteLine(Constant.strMsgValidDate);
                            intFlag++;
                            return true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine(Constant.strMsgNotDate);                      //Display messege if date is not valid
                    return false;
                }
            }
            else
            {
                Console.WriteLine(Constant.strMsgNotDate);                          //Display messege if date is not valid
                return false;
            }
           // Console.WriteLine("intFlag= "+intintFlag);
        }
        #endregion valid
    }
    #endregion DateValidate
}
