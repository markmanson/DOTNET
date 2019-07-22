
namespace Program
{
    /*--------------------------------------------------------------------------------------------------------------------
        Name:ExceptionGenerate.cs
        Author:Monal Shah
        Description:"Change the ArmoredVehicle class so that the Destruct method throws an exception VehicleCannotBeDestroyedException.
                     Handle the above exception in the arraylist loop written above."

                      In this program the our own Exception is created
        CreatedDate: 2010/09/14 by Monal Shah
-------------------------------------------------------------------------------------------------------------------
*/
    class ExceptionGenerate:System.ApplicationException
    {
        public string strM = string.Empty;
        #region ExceptionGenerate
        /// <summary>
        /// Name:ExceptionGenerate(Constructor)
        /// argument returntype:string
        /// Author:Monal shah
        /// CreatedDate: 2010/09/14 by Monal Shah
        /// </summary>
        /// <param name="strMsg"></param>
        public ExceptionGenerate(string strMsg)
            : base(strMsg)
        {
            strM = strMsg.ToString();
        }
        #endregion
    }
}
