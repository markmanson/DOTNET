using System;
/// <summary>
///NameSpace:CSharp
/// Description://Fundamental study programs of C#
/// Author:bhumi
/// Created On:21/5/2015
/// </summary>
/// 
namespace CSharp
{
    /// <summary>
    /// Class Name:Power
    /// Description:////Accept a number N and a number M from the user and print the value of N raised to the power of M, i.e. N^M
    /// Author:
    /// Created On:19/5/2015
    /// </summary>
    /// 
    class Power
    {
        #region Power of Number
        ConstantMessage objconst;//object creation                
        ///<summary>
        ///Method Name:FindPowerNum
        /// Description://Power function
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>                
        public void FindPowerNum()
        {
            try
            {
                int N_Base, M_power;
                objconst = new ConstantMessage();
                Console.WriteLine(objconst.strfindpower);
                Console.WriteLine(objconst.strbase);
                N_Base = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(objconst.strpower);
                M_power = Convert.ToInt32(Console.ReadLine());
                //find the N^M
                double result = Math.Pow(N_Base, M_power);
                Console.WriteLine(N_Base + "^" + M_power + "=" + result);
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
