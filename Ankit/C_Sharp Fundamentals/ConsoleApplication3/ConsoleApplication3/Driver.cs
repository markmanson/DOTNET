using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vehicles;
#region Users
//NAME                      : USERS
//AUTHER                    : ANKIT SHARMA
//CREATED DATE              : 09/07/2012
//DESCRIPTION               : TO CREATE A NAMESPACE WITH NAME USERS
namespace Users
{
    //NAME                      : DRIVER
    //AUTHER                    : ANKIT SHARMA
    //CREATED DATE              : 09/07/2012
    //DESCRIPTION               : TO CREATE A CLASS DRIVERS  WITH NAMESPACE USERS
    class Driver : Vehicle
    {
        Vehicle objVehicle;
        public void Drive()
        {
            try
            {
                objVehicle = new Vehicle();                     //INITIALIZING THE OBJECT OF CLASS VEHICLE
                objVehicle.Drive();                             //CALL THE DRIVE FUNCTION OF CLASS VEHICLE
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                   //DISPLAY AN ERROR MESSEGE IF ANY ERROR IS OCCURED
            }
            finally
            {
                objVehicle = null;                              //DESTROYING THE OBJECT OF CLASS VEHICLE
            }
        }

    }
}
#endregion Users
//namespace ConsoleApplication3
//{
//    //NAME                      : DRIVER
//    //AUTHER                    : ANKIT SHARMA
//    //CREATED DATE              : 09/07/2012
//    //DESCRIPTION               : TO CREATE A CLASS DRIVERS  WITH NAMESPACE USERS
//    class Driver:Vehicle
//    {
//        Vehicle objVehicle;      
//        public void Drive()
//        {
//            try
//            {
//                objVehicle = new Vehicle();
//                objVehicle.Drive();
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }
//        }       

//    }
//}
