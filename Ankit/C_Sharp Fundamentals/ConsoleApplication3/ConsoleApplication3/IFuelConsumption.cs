namespace ConsoleApplication3
{
    #region IFuelConsumption
    //Name                      : IFuelConsumption
    //Auther                    : Ankit Sharma
    //Created Date              : 09/07/2012
    //Description               : To make a interface name IFuelConsumption
    interface IFuelConsumption
    {   
        //METHOD DRIVE **********************************************************
        void Drive();
        //PROPERTY FuelEfficiency  **********************************************
        int FuelEfficiency
        {
            get;

            set;

        }
    }
    #endregion IFuelConsumption
}
