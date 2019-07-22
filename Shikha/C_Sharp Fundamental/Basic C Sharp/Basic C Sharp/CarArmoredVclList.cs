using System;

namespace Vehicles
{
    #region CarArmoredVclList
    //NAME          :- CarArmoredVclList
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- Class that contain methods and property
    //CREATED DATE  :- 19/07/2012
    class CarArmoredVclList
    {
        string strModelnm = string.Empty;
        public CarArmoredVclList(string strMd)
        {
            strModelnm = strMd;
        }
        
        public String ModelName { get; set; }                                     
       
        public void Destruct()
        {
            Console.WriteLine(Basic_C_Sharp.Constant.strCarDes);
        }
        public override string ToString()                                    //allowing print contents as a string
        {
            Console.WriteLine(Basic_C_Sharp.Constant.strInfCar + ":-" + strModelnm);
            Destruct();
            return "";
        }
    }
    #endregion CarArmoredVclList
}

                

            
           
                

           
