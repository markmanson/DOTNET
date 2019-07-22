using System;

//NAME          :- Vehicles
//AUTHOR        :- SHIKHA MALIK
//DESCRIPTION   :- Namespace that contain defination of Class
//CREATED DATE  :- 19/07/2012

namespace Vehicles
{
    #region
    //NAME          :- Vehicle
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- Class that contain method
    //CREATED DATE  :- 20/07/2012

   class Vehicle
    {
        //NAME          :- Drive
        //AUTHOR        :- SHIKHA MALIK
        //DESCRIPTION   :- Class that contain properties
        //CREATED DATE  :- 20/07/2012
        public void  Drive()
        {
            Console.WriteLine(Basic_C_Sharp.Constant.strVhcleMtn);                //Message for Display
        }

        public override string ToString()                         //allowing print contents as a string
        {
            Drive();
            return "";
        }

    }
    #endregion
}

                       
       