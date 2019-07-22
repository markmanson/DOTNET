using System;
namespace ConsoleApplication3
{
    #region Rounding
    //Name                      : Rounding 
    //Auther                    : Ankit Sharma
    //Created Date              : 28/06/2012
    //Description               : To display the intigral part of a double  
    class Rounding
    {
                                                              //Declaring the object of class Common
        #region round 
        //Fuction to display the integral part of a double
        public void round()
        {
            double dblNum;
            string strNum;
            try
            {
                Console.WriteLine(Constant.strMsgEntrFlt);                  //Display msg to enter a float 
                dblNum = double.Parse(Console.ReadLine());                  //Getting input  from user
                Console.WriteLine(Constant.strMsgCast);                     //Display messege by casting
                Console.WriteLine((int)dblNum);                             //Display intigral part by using casting
                Console.WriteLine(Constant.strMsgRound);                    //Display msg to show by rounding
                Console.WriteLine(Math.Round(dblNum));                      //Display intigral part by using rounding
                strNum = Convert.ToString(dblNum);                          //Convert double into string
                int strlength = strNum.Length - 1;                          //Finding the length of string
                int loc = strNum.IndexOf(".");                              //Finding the location of decimal 
                //Console.WriteLine("loc "+loc);
                char chrsub = strNum[loc+1];                                //Finding the next digit from decimal
                //Console.WriteLine("strsub " + chrsub);
                //Console.WriteLine("chrsub "+chrsub);
                string str = Convert.ToString(chrsub);                         
                int temp = int.Parse(str);                                  //Convert that digit into number
                //Console.WriteLine("temp= " + temp);
                int intsub = Convert.ToInt32(strNum.Substring(0, loc));
                Console.WriteLine(Constant.strMsgMan);
                // Console.WriteLine("intsub= "+intsub);
                //Console.WriteLine("temp= " + temp);
                if (temp < 5)                                               //Checking if the digit after decimal is greater than 5 or not
                {
                    Console.WriteLine(intsub);                              //Display the final result 
                }
                else
                {
                    Console.WriteLine(intsub + 1);                          //Display result if digit after was lesser than 5
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                               //Display messege if any exception is occured
            }
        }    
        #endregion round
    }
        #endregion Rounding 
}
