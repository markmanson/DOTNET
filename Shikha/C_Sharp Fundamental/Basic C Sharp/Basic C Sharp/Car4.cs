using System;
using Vehicles;

namespace Basic_C_Sharp
{
    #region Car4
    //NAME          :- Car4
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- Class that contain Destruct method and property
    //CREATED DATE  :- 19/07/2012
    class Car4 : IVehicle1                                                  //inherit IVehicle interface
    {
        string strModelName = Constant.strEntrValue;                             //Declaration of variable
        public string ModelName                                           //Define ModelName property for get, set value
        {
            get
            {
                return strModelName;

            }
            set
            {
                strModelName = value;
            } 
        }
        public void Destruct()                                             //destruct method defination
       {
           Console.WriteLine(Constant.strCarDes);
       }
        public override string ToString()                                 //allowing print contents as a string
        {
           Destruct();
           return "";
        }
    }
    #endregion Car4
}
