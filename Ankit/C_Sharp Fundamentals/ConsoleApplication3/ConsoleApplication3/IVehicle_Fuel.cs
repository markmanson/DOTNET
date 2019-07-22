
namespace ConsoleApplication3
{
    #region IVehicle_Fuel
    //Name                      : IVehicle_Fuel
    //Auther                    : Ankit Sharma
    //Created Date              : 09/07/2012
    //Description               : To make a interface name IVehicle_Fuel
    interface IVehicle_Fuel
    {
        //PRPERTY INITIAL FUEL  ************************************************
        int InitialFuel
        {
            get;
            set;
        }

        #region Drive
        //METHOD DRIVE   *******************************************************************************************
        void Drive();
        #endregion Drive
        ////METHOD DESTRUCT ******************************************************************************************
        //void Destruct();
    }
    #endregion IVehicle_Fuel
}
