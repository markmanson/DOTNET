using System;
using Vehicles;
namespace ConsoleApplication3
{
    #region CarAllMsg
    //Name                      : CarAllMsg
    //Auther                    : Ankit Sharma
    //Created Date              : 09/07/2012
    //Description               : To call its own method
    class CarAllMsg : Vehicle
    {
        string strModelName;                                                    //DECLARING A STRING
        CarMsg objCarMsg;                                                       //DECLARING THE OBJECT FOR CLASS CARMSG
        public string ModelName                                                 //PROPERTY TO GET STRMODENAME
        {
            get { return strModelName; }
            set { strModelName = value; }
        }
        #region Drive
        //Method Drive to display car is in motion ***********************************************************************
        public override void Drive()
        {
            try
            {
                objCarMsg = new CarMsg();                                       //INITIALIZING THE OBJECT OF CLASS CARMSG
                objCarMsg.Drive();                                              //CALL THE FUNCTION DRIVE OF CLASS CARMSG
                base.Drive();                                                   //CALL THE FUNCTION DRIVE OF BASE CLASS
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                                   //DISPLAY A MESSEGE IF ANY ERROR IS OCCURED
            }
            finally
            {
                objCarMsg = null;                                               //DESTROY THE OBJECT OF CLASS CARMSG
            }
        }
        #endregion Drive
    }
    #endregion CarAllMsg
}
