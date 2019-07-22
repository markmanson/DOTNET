using System;
namespace Basic_C_Sharp
{
    #region
    //NAME          :- CastValue
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- CREATE CUSTOMER CLASS
    //CREATED DATE  :- 17/07/2012
    class CastValue
    {
        //NAME          :- CastFltMy
        //AUTHOR        :- SHIKHA MALIK
        //DESCRIPTION   :- CREATE CUSTOMER CLASS
        //CREATED DATE  :- 17/07/2012

        public void CastFltMy()
        {
            int intV, intVR; double dblI; string str, strDB;                  //Declaration of variable
            try
            {

                Console.WriteLine(Constant.strEntrDbl);                          // Enter value    
                dblI = double.Parse(Console.ReadLine());                        // read the value in double

                Console.WriteLine(Constant.strCasting);
                intV = Convert.ToInt32(dblI);                                 //Convert Double value into integer

                Console.WriteLine(intV.ToString());                              //print value

                Console.WriteLine(Constant.strRoundg);                          //Display message for rounding
                intVR = (int)(Math.Round(dblI));                               //Convert into integer using round
                Console.WriteLine(intVR.ToString());                          // print value

                Console.WriteLine(Constant.strManually);                      //Display message for manually
                str = dblI.ToString();
                strDB = dblI.ToString();

                strDB = strDB.Substring(strDB.IndexOf(".") + 1, 1);             //store value of aftr 1 space of .

                if (Int32.Parse(strDB) <= 5)                               //cheak condition for stored value
                {
                    str = str.Substring(0, str.IndexOf("."));                //if true print value before .
                    Console.WriteLine(str);
                }
                else
                {
                    str = str.Substring(0, str.IndexOf("."));
                    str = (int.Parse(str) + 1).ToString();                 // else add 1 last index or before .
                    Console.WriteLine(str);
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                             // throw exception
            }

            finally                                                      // reallocate memory
            {
                str= null;
                strDB = null;
            }

        }
    }
    #endregion
}
