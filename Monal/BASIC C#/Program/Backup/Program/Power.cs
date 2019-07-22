using System;

namespace Program
{
    /*-------------------------------------------------------------------------------------------------------------------
   Name:Power.cs
   Author:Monal Shah
   Description:This Program is calculate the Power value of the entered numeric value and Power value is also entered by user.
   Example:1 no. is:2
           2 no. is:3
           Ans:2*2*2=8
   CreatedDate: 2010/09/06 by Monal Shah
   -------------------------------------------------------------------------------------------------------------------
   */
    class Power
    {
        /*---------------------------------------------------------------------------------------------------------------
           Name:PowerValue 
           Paramametres:0
           Description:This method is used for calculating the Power value of the entered numeric value and Power value is also entered by user.
           Author:Monal Shah
           CreatedDate: 2010/09/06 by Monal Shah
       ---------------------------------------------------------------------------------------------------------------
       */
        public void PowerValue()
        {
            /*
           [Date]:2010/09/09 
           [Author Name]:Monal Shah
           Description:Add try catch and finally Block in code
          */
            try
            {
                Console.WriteLine("Enter Numeric Value");
                double dblN = System.Convert.ToDouble(Console.ReadLine()); //dblN is the variable of double datatype
                Console.WriteLine("Enter Numeric Value");
                double dblM = System.Convert.ToDouble(Console.ReadLine()); //dblM is the variable of double datatype
                double dblValue = Convert.ToDouble(Math.Pow(dblN, dblM)); //here in below code with the help of Pow method of math class we can calculate the powervalue
                Console.WriteLine("N^M: " + dblValue);//The Result will be displayed
                Console.ReadLine();
            }
            catch (Exception ExException)
            {
                Console.WriteLine("ERROR:" + ExException.Message);//throw exception
            }
        }
    }
}
