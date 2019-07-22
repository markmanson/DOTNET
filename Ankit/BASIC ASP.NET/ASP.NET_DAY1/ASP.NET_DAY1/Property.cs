
namespace ASP.NET_DAY1
{
    #region Property
    /*************************************************************************************************************
    * CLASS NAME                                   :::                     PROPERTY                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     01/08/2012
    * DESCRIPTION                                  :::                     TO MAKE A CLASS TO MAKE PROPERTY
    * **********************************************************************************************************/
    public class Property
    {
        string strName;                                         //DECLARATION OF STRING VARIABLE
        //PROPERTY TO TAKE THE VALUE OF NAME  ******************************************************************
        public string Name
        {
            get
            {
                return strName;
            }
            set
            {
                strName = value;
            }
        }
    }
    #endregion Property
}
