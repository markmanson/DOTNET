using System;
//NAME          :- Vehicles
//AUTHOR        :- SHIKHA MALIK
//DESCRIPTION   :- Namespace which contain classes
//CREATED DATE  :- 19/07/2012

namespace Vehicles
{
    #region Car2
    //NAME          :- Car2
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- Class that contain Drive method
    //CREATED DATE  :- 19/07/2012
    class Car2 : Car                                                        //inherit Car class
    {
        public void Drive()
        {
           Console.WriteLine(Basic_C_Sharp.Constant.strCarMotion);                       //Message for Display
            base.Drive();                                                 //call base class drive method                                              
        }
    }
    #endregion Car2
}
   
