using System;
/// <summary>
///NameSpace:CSharp
/// Description://Fundamental study programs of C#
/// Author:bhumi
/// Created On:21/5/2015
/// </summary>
namespace CSharp
{
    /// <summary>
    /// Class Name:DoubleToInt
    /// Description://"Accept a double value from user.  Print its integer part through:                    
    /// Author:
    /// Created On:21/5/2015
    /// </summary>
    ///     
    class DoubleToInt
    {
        #region Convert Double Datatype to Integer
        ConstantMessage objconst;//object creation                                               
        ///<summary>
        ///Method Name:DataTypeConv
        /// Description://convert double to integer
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>                                
        public void DataTypeConv()
        {
            objconst = new ConstantMessage();            
            try
            {
                //variables
                double double_number,integer_round;
                int integer_cast, integer_Manual;
                Console.WriteLine(objconst.strdoubleInt);
                //Get the number from user                
                Console.WriteLine(objconst.strdoubleno);
                double_number = Convert.ToDouble(Console.ReadLine());
                //Printing integer part of double number
                //Casting
                Console.WriteLine(objconst.strcast);                
                integer_cast = (int)double_number;
                Console.WriteLine(integer_cast);
                Console.WriteLine(objconst.strround);
                //round off                
                integer_round = Math.Round(double_number);
                Console.WriteLine(integer_round);
                //Manually
                Console.WriteLine(objconst.strmanual);                
                integer_Manual = Convert.ToInt32(double_number);
                Console.WriteLine(integer_Manual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                objconst = null;
            }
        }
        #endregion
    }
}
