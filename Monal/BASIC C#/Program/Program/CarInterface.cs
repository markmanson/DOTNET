using System;

namespace Program
{
    /*--------------------------------------------------------------------------------------------------------------------
        Name:CarInterface.cs
        Author:Monal Shah
        Description:Change the Vehicle class to an interface named IVehicle.
                    The Car class should now implement the interface Ivehicle.

       
        CreatedDate: 2010/09/14 by Monal Shah
    -------------------------------------------------------------------------------------------------------------------
*/
    class CarInterface : IVehicle
    {
        #region IVehicle Members
        #region Drive
        /// <summary>
        /// Name:Drive
        /// Description:Add method Drive to the class.
        ///             This method should print a message 'Vehicle in motion".
        /// Author:Monal shah
        /// CreatedDate: 2010/09/14
        /// </summary>
        public void Drive()
        {
            Console.WriteLine("Vehicle in Motion");
        }
        #endregion
        #endregion
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
            get { return _strModelName; }
            set { _strModelName = value; }
        }
        #endregion
        #region ShowMessage
        /// <summary>
        /// Name:ShowMessage
        /// Description: This method will return the value  ModelName
        /// Author:Monal shah
        /// CreatedDate: 2010/09/14
        /// </summary>
        public void ShowMessage()
        {
            CarInterface objC = new CarInterface();//objc is object of class CarInterface
            try
            {
                objC.ModelNme = "HondaCity";
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
