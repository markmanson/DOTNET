using System;
namespace ConsoleApplication3
{
    #region CarInterface
    //Name                      : CarInterface
    //Auther                    : Ankit Sharma
    //Created Date              : 09/07/2012
    //Description               : To make a class name CarInterface
    class CarInterface:IVehicle
    {
        #region Drive
        //METHOD DRIVE ********************************************************************************************      
        public void Drive()
        {            
            Console.WriteLine(Constant.strVehicle);
        }
        #endregion Drive
        #region Destruct
        //METHOD DESTRUCT  *****************************************************************************************
        public void Destruct()
        {
            throw new NotImplementedException();
        }
        #endregion Destruct
    }
    #endregion CarInterface
}
