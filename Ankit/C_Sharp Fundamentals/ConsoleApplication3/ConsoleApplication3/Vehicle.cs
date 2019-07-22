using System;

#region Vehicles
//Name                      : Namespace Vehicles
//Auther                    : Ankit Sharma
//Created Date              : 09/07/2012
//Description               : To declare a namespace named vehicles
namespace Vehicles
{
    #region Vehicle
    //Name                      : Vehicle
    //Auther                    : Ankit Sharma
    //Created Date              : 09/07/2012
    //Description               : To make a class Vehicle with namespace Vehicles 
    class Vehicle
    {
        #region Drive
        //FUNCTION TO DISPALY A MESSEGE THAT VEHICLE IS IN MOTION ******************************************
        public virtual void Drive()
        {
            Console.WriteLine("Vehicle in motion");
        }
        #endregion Drive
    }
    #endregion Vehicle
}
#endregion Vehicles
//namespace ConsoleApplication3
//{
//    #region Vehicle
//    //Name                      : Vehicle
//    //Auther                    : Ankit Sharma
//    //Created Date              : 09/07/2012
//    //Description               : To make a class Vehicle with namespace Vehicles 
//    class Vehicle
//    {
//        #region Drive
//        //FUNCTION TO DISPALY A MESSEGE THAT VEHICLE IS IN MOTION ******************************************
//        public virtual void Drive()
//        {
//            Console.WriteLine("Vehicle in motion");
//        }
//        #endregion Drive
//    }
//    #endregion Vehicle
//}
