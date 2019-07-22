using System;
namespace ConsoleApplication3
{
    #region ArmoredVehicle2
    //Name                      : ArmoredVehicle2
    //Auther                    : Ankit Sharma
    //Created Date              : 09/07/2012
    //Description               : To make a class name ArmoredVehicle2
    class ArmoredVehicle2 : IVehicle
    {
        #region Drive
        //METHOD DRIVE ****************************************************************************************************
        public void Drive()
        {
            throw new NotImplementedException();                            //THROW EXCEPTION IF METHOD IS NOT IMPLEMENTED
        }
        #endregion Drive
        #region Destruct
        //METHOD DESTRUCT **************************************************************************************************
        public void Destruct()
        {
            ExceptionGenerated objE = new ExceptionGenerated();

            //try
            // {
            Console.WriteLine(Constant.strNotDes);
            ///}
            //catch (Exception e)
            //{
            // Console.WriteLine(e.Message);
            //}
        }
        #endregion Drive
    }
    #endregion ArmoredVehicle2
}
