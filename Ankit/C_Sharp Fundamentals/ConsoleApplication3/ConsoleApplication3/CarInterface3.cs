using System;

namespace ConsoleApplication3
{
    #region CarInterface3
    //Name                      : IFuelConsumption
    //Auther                    : Ankit Sharma
    //Created Date              : 09/07/2012
    //Description               : To make a class name CarInterface3
    class CarInterface3:IVehicle
    {
        string strModelName;                                            //DECLARE A STRING 
        public CarInterface3(string modname)
        {
            strModelName = modname;
        }
        public string ModelName                                         //PROPERTY TO GET MODELNAME
        {
            get { return strModelName; }
            set { //strModelName = mod; 
            }
        }
        #region Drive
        //METHOD DRIVE *******************************************************************************************
        public void Drive()
        {
            throw new NotImplementedException();                    //THROW EXCEPTION IF METHOD IS NOT IMPLEMENTED
        }
        #endregion
        #region Destruct
        //METHOD DESTRUCT *****************************************************************************************
        public void Destruct()
        {
            Console.WriteLine(Constant.strDes);                     //DISPLAY MESSEGE CAR IS DESTRUCTED
        }
        #endregion Destruct
        #region ToString
        //METHOD TOSTRNIG **************************************************************************************** 
        public override string ToString()
        {
            //string strMdl;
            return "Model name :-" + strModelName;
        }
        #endregion ToString
    }
    #endregion CarInterface3
}
