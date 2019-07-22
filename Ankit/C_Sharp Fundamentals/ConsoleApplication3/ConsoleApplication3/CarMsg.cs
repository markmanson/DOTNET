using System;
using Vehicles;
namespace ConsoleApplication3
{
    #region CarMsg
    //Name                      : CarMsg
    //Auther                    : Ankit Sharma
    //Created Date              : 09/07/2012
    //Description               : To call its own method
    class CarMsg:Vehicle
    {
        string strModelName;                                            //DECLARE A STRING 
        public string ModelName                                         //PROPERTY TO GET MODELNAME
        {
            get { return strModelName; }
            set { strModelName = value; }
        }
        #region Drive
        //Method Drive to display car is in motion ***********************************************************************
        public override void Drive()
        {
            Console.WriteLine(Constant.strCar);                     //DISPLAY THE MESSEGE CAR IS IN MOTION
            base.Drive();
        }
        #endregion Drive
    }
    #endregion CarMsg
}
