using System;

namespace Vehicles
{
    #region
    //NAME          :- VehicleNtDestydException
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- Exception class that contain method
    //CREATED DATE  :- 20/07/2012
    class VehicleNtDestydException :Exception                  //Create class for throw exception
    {
        public void  VehicleNtDestydExcep(string strs)
        {
            Console.WriteLine(strs);
        }
    }
    #endregion
}
