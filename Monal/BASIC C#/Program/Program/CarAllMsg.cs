using Vehicles;
using System;
namespace Program
{
    /*--------------------------------------------------------------------------------------------------------------------
        Name:CarAllMsg.cs
        Author:Monal Shah
        Description:Change code in the Car class so that when the Drive method of the Car class is called,
                   it will execute its own code as well as invoke the parent class method.
       
        CreatedDate: 2010/09/14 by Monal Shah
-------------------------------------------------------------------------------------------------------------------
*/
    class CarAllMsg:Vehicle
    {
        #region Drive
        /// <summary>
        ///Name:Drive
        /// Description:Drive method of the Car class to display a message "Car is in motion".
        /// Author:Monal shah
        /// CreatedDate: 2010/09/14
        /// </summary>
        public new void Drive()
        {
            CarMsg objMsg = new CarMsg();//objMsg is object of CarMsg
            try
            {
                base.Drive();//Parent class method drive is called
                objMsg.Drive();//Drive Method of CarMsg is called
            }
            catch (Exception exException)
            {
                Console.WriteLine("Error:" + exException.Message);
            }
            finally
            {
                objMsg = null;
            }

        }
        #endregion
    }
}
