
namespace Program
{
    /*--------------------------------------------------------------------------------------------------------------------
        Name:ExceptionArmodVehicle.cs
        Author:Monal Shah
        Description:"Change the ArmoredVehicle class so that the Destruct method throws an exception VehicleCannotBeDestroyedException.
                     Handle the above exception in the arraylist loop written above."


        CreatedDate: 2010/09/14 by Monal Shah
-------------------------------------------------------------------------------------------------------------------
*/
    class ExceptionArmodVehicle
    {
        #region Destruct
        /// <summary>
        /// Name:Destruct
        /// Description:This method throws an exception and print a message 'Vehicle Can't be destroyed".
        /// Author:Monal shah
        /// CreatedDate: 2010/09/14
        /// </summary>
        public void Destruct()
        {
            throw new ExceptionGenerate("Vehicle cannot be destroyed");


        }
        #endregion


    }
}
