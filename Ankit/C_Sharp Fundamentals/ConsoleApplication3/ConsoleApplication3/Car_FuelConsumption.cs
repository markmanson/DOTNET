using System;
namespace ConsoleApplication3
{
    class Car_FuelConsumption:IFuelConsumption,IVehicle_Fuel
    {
        #region Car_FuelConsumption
        //Name                      : Armored_Fuel
        //Auther                    : Ankit Sharma
        //Created Date              : 09/07/2012
        //Description               : To make a class name Armored_Fuel
        int intFuleE, intInitialFuel;
        // Default Constructor body***********************************************************************************************          
        public Car_FuelConsumption()
        { }
        // Parameterized Constructor body*****************************************************************************************
        public Car_FuelConsumption( int intInitialFuel)
        {
            this.intInitialFuel = intInitialFuel; 
            intFuleE = 14;
        }
        // Property implementation:************************************************************************************************
        public int FuelEfficiency
        {
            get { return intFuleE; }
            set { intFuleE = value; }
        }
        // Property implementation:*************************************************************************************************
        public int InitialFuel
        {
            get { return intInitialFuel; }
            set { intInitialFuel = value; }
        }
        #region Drive 
        //METHOD DRIVE   ***********************************************************************************************************
        public void Drive()
        {
            int intKm, intFuelLeft;
            //Console.WriteLine("Car Class Code : -\n");
            try
            {
                Console.WriteLine("Plese Enter Value of Kilometres Driven.  \n");
                intKm = int.Parse(Console.ReadLine());
                intFuelLeft = (intInitialFuel * intKm) - intFuleE;
                if (intFuelLeft > 0)
                {
                    int fuel = intFuelLeft / intFuleE;
                    Console.WriteLine("Amount of fuel left in Car = " + fuel);
                }
                else
                {
                    Console.WriteLine("No Fuel Left : - ");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion Drive       
    }
        #endregion Car_FuelConsumption
}
