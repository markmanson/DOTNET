using System;
using Vehicles;

namespace Program
{
    /*--------------------------------------------------------------------------------------------------------------------
         Name:Car.cs
         Author:Monal Shah
         Description:Add class Car to the Vehicles namespace.
                     Inherit this class from the Vehicle class.
                     Add a method called Drive to this class.
                     Add a property called ModelName to the class.
                     This property will return the value "Passenger Car"
                     Call the parent method from this method.
       
         CreatedDate: 2010/09/14 by Monal Shah
 -------------------------------------------------------------------------------------------------------------------
 */
    class Car:Vehicle
    {
        public string _strModelName = "";
        #region MobelName
        /// <summary>
        /// Name:ModelNme
        /// Description:Create propertyName ModelName
        /// Author:Monal shah
        /// CreatedDate: 2010/09/14
        /// </summary>
        /// </summary>
        
        public string ModelNme
        {
            get {return _strModelName; }
            set { _strModelName = value; }
        }
        #endregion
        #region Drive
        /// <summary>
        /// Name:Drive
        /// Description: Call the parent method from this method.
        /// Author:Monal shah
        /// CreatedDate: 2010/09/14
        /// </summary>
        public new void Drive()
        {
            base.Drive();//here parent method will be called


        }
        #endregion
        #region ShowMessage
        /// <summary>
        /// Name:ShowMessage
        /// Description: This method will return the value "Passenger Car"
        /// Author:Monal shah
        /// CreatedDate: 2010/09/14
        /// </summary>
        public void ShowMessage()
        {
            Car objC = new Car();//objC is object of Car Class
            try
            {

                objC.ModelNme = "Passenger Car";
                Console.WriteLine(objC.ModelNme);
            }
            catch (Exception exException)
            {
                Console.WriteLine("Error:" + exException.Message);
            }
            finally
            {
                objC = null;
            }
        }
        #endregion
    }
}
