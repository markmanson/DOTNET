
namespace Program
{
    /*--------------------------------------------------------------------------------------------------------------------
      Name:NoFuelLeftException.cs
      Author:Monal Shah
      Description:If the amount of fuel left is less than zero, throw an exception NoFuelLeftException. 

                    In this program the our own Exception is created
      CreatedDate: 2010/09/14 by Monal Shah
-------------------------------------------------------------------------------------------------------------------
*/
    class NoFuelLeftException:System.ApplicationException
    {
          public string strM = string.Empty;
          #region NoFuelLeftException 
          /// <summary>
          /// Name:NoFuelLeftException(Constructor)
          /// argument returntype:string
          /// Author:Monal shah
          /// CreatedDate: 2010/09/14 by Monal Shah
          /// </summary>
          /// <param name="strMsg"></param>
        public NoFuelLeftException(string strMsg)
            : base(strMsg)
        {
            strM = strMsg.ToString();
        }
          #endregion
    }
}
