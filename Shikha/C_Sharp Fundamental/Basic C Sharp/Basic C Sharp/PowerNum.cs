using System;

namespace Basic_C_Sharp
{
    #region PowerNum
    //NAME          :- PowerNum 
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- RAISED THE POWER OF dblN    
    //CREATED DATE  :- 13/07/2012

    class PowerNum
    {
        //NAME          :- Pwrnum
        //AUTHOR        :- SHIKHA MALIK
        //DESCRIPTION   :- RAISED THE POWER OF dblN    
        //CREATED DATE  :- 13/07/2012

       public void Pwrnum()
        {
             double dblM, dblN, dblValue;            // Declaration of variable
            try
            {
                Console.WriteLine(Constant.strEntrNn);      // Display message
                    dblN=double.Parse(Console.ReadLine());   // read the dblValue of dblN
                Console.WriteLine(Constant.strEntrNm);     // Display message
                    dblM=double.Parse(Console.ReadLine());   // read the value of dblM      
                    dblValue= Math.Pow(dblN,dblM);                     // use Math.Pow(dblN,dblM) function for calculate the power of enter number
                Console.WriteLine(" Value is"  + dblValue);  // Show the value after result
            }
            catch(Exception ex)
            {
                 System.Console.WriteLine(ex.Message);    // throw exception
            }
        }
    }
    #endregion 
}
