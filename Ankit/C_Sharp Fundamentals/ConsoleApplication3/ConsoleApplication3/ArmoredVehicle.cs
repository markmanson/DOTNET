using System;
namespace ConsoleApplication3
{
    #region ArmoredVehicle
    //Name                      : ArmoredVehicle
    //Auther                    : Ankit Sharma
    //Created Date              : 09/07/2012
    //Description               : To make a class name ArmoredVehicle
    class ArmoredVehicle:IVehicle1
    {
        #region Drive
        //METHOD DRIVE ***********************************************************************************************************
        public void Drive()
        {
            throw new NotImplementedException();                                                //THROW EXCEPTION NOT IMPLEMENTED
        }
        #endregion Drive
        #region Destruct
        public void Destruct()
        {
            Console.WriteLine(Constant.strNotDes);
        }
        #endregion Destruct
    }
#endregion ArmoredVehicle
}
