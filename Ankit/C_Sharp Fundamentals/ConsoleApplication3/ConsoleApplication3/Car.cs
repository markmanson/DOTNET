using System;
using Vehicles;
namespace ConsoleApplication3
{
    #region Car
    //Name                      : Car
    //Auther                    : Ankit Sharma
    //Created Date              : 09/07/2012
    //Description               : Car class
    class Car:Vehicle
    {
        string str_ModeName;                                                            //DECLARE A STRING
        public string ModelName                                                         //PROPERTY TO GET MODEL NAME
        {
            set { str_ModeName = value; }
            get { return str_ModeName; }
        }
        #region Drive
        //Method to call the method of class base  ********************************************************************************
        public new void Drive()
        {
            try
            {
                base.Drive();                                                           //CALL THE METHOD DRIVE FROM BASE CLASS 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                                           //DISPLAY MESSEGE IF ANY ERROR IS OCCURED
            }
        }       
        #endregion Drive
    }
    #endregion Car
}
