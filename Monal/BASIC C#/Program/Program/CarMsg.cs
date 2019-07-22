using System;

namespace Program
{
    /*--------------------------------------------------------------------------------------------------------------------
        Name:CarMsg.cs
        Author:Monal Shah
        Description:code to the Drive method of the Car class to display a message "Car is in motion".
                    Call the Drive method of the Car class and check the result.
       
        CreatedDate: 2010/09/14 by Monal Shah
-------------------------------------------------------------------------------------------------------------------
*/
    class CarMsg:Car
    {
        #region Drive
        /// <summary>
        /// Name:Drive
        /// Description:Drive method of the Car class to display a message "Car is in motion".
        /// Author:Monal shah
        /// CreatedDate: 2010/09/14
        /// </summary>
        public new void Drive()
        {
            Console.WriteLine("Car is in Motion");
        }
        #endregion
    }
}
