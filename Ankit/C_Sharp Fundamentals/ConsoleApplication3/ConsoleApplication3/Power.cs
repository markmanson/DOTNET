using System;
namespace ConsoleApplication3
{
    #region Power
    //Name                      : Power
    //Auther                    : Ankit Sharma
    //Created Date              : 28/06/2012
    //Description               : To calculate n raise to the power m
    class Power
    {
        #region Pwr
        //*********************************Function to calculate n raise to the power m*************************************************
        public void pwr()
        {
            int intM,intN;
            double dblP;
            try
            {
                Console.WriteLine(Constant.strEntrBse);
                intN = int.Parse(Console.ReadLine());                                               //Input base number from user
                Console.WriteLine(Constant.strEntrExp);
                intM = int.Parse(Console.ReadLine());                                               //Input exponent from user                                                                             
                dblP = Math.Pow(intN, intM);                                                        //Calculating base raise to the power exponent
                Console.WriteLine(intN + " raise to the power " + intM + " is " + dblP);            //Display the result                               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion Power
    }
    #endregion Power
}
