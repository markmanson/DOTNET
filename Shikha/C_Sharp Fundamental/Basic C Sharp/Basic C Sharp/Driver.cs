using System;
using Vehicles;
//NAME          :- Users
//AUTHOR        :- SHIKHA MALIK
//DESCRIPTION   :- Namespace that contain defination of Class
//CREATED DATE  :- 19/07/2012

namespace Users
{
    #region
    //NAME          :- Drivers
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- Class that contain method
    //CREATED DATE  :- 19/07/2012

    class Driver                        
    {
        public  void Drive()
        {
            Vehicle objVehicle;
            try
            {
                objVehicle = new Vehicle();                         //create object of vehicle class, which is define in vehicles name space
                objVehicle.Drive();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                objVehicle = null;
            }

        }
    }
    #endregion
}
