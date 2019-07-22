using Vehicles;
using System;

namespace Users
{

    /*--------------------------------------------------------------------------------------------------------------------
         Name:Driver.cs
         Author:Monal Shah
         Description:Create class Driver with namespace Users.  Add method Drive to the class.
                     From the Driver.Drive method, call the Vehicle.Drive method
                     
       
         CreatedDate: 2010/09/14 by Monal Shah
 -------------------------------------------------------------------------------------------------------------------
 */
    class Driver
    {
        #region Drive
        /// <summary>
        /// Name:Drive
        /// Description:Add method Drive to the class.
       ///              From the Driver.Drive method, call the Vehicle.Drive method
        /// Author:Monal shah
        /// CreatedDate: 2010/09/14
        /// </summary>
        public void Drive()
        {
            Vehicle objVehicle = new Vehicle();//Create the object of Vehicle class
            try
            {
                objVehicle.Drive();//Call the drive method of Vehicle class
            }
            catch (Exception ExException)
            {
                Console.WriteLine("ERROR:" + ExException.Message);//throw exception
            }
            finally
            {
                objVehicle = null;
            }
        }
        #endregion

    }
}
