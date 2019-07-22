using System;
namespace ConsoleApplication3
{
    #region CarInterface2
    //Name                      : CarInterface2
    //Auther                    : Ankit Sharma
    //Created Date              : 09/07/2012
    //Description               : To make a class name CarInterface2
    class CarInterface2:IVehicle1
    {
        string strModelName;                                            //DECLARE A STRING 
        public string ModelName                                         //PROPERTY TO GET MODELNAME
        {
            get { return strModelName; }
            set { strModelName = value; }
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
        public override string ToString()
        {
            //string strMdl;
            return "Model name :-" + strModelName;
        }
    }
    #endregion CarInterface2
}
