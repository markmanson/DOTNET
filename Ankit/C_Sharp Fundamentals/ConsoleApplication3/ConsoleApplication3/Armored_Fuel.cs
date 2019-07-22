using System;

namespace ConsoleApplication3
{
    #region Armored_Fuel
    //Name                      : Armored_Fuel
    //Auther                    : Ankit Sharma
    //Created Date              : 09/07/2012
    //Description               : To make a class name Armored_Fuel
    class Armored_Fuel : IFuelConsumption, IVehicle_Fuel
    {
        int intFuleE, intInitialFuel;
        // Default Constructor body ************************************************************************
        public Armored_Fuel()
        { }
        // Parameterized Constructor body********************************************************************
        public Armored_Fuel(int intInitialFuel)
        {
            this.intInitialFuel = intInitialFuel;
            intFuleE = 5;
        }
        // Property implementation:**************************************************************************
        public int FuelEfficiency
        {
            get { return intFuleE; }
            set { intFuleE = value; }
        }
        // Property implementation:**************************************************************************
        public int InitialFuel
        {
            get { return intInitialFuel; }
            set { intInitialFuel = value; }
        }

        public void Drive()
        {
            //Console.WriteLine("Armored Vehicle Class Code : -\n");
            int intKm, intFuelLeft;
            Console.WriteLine(Constant.strEntrKm);
            intKm = int.Parse(Console.ReadLine());
            intFuelLeft = (intInitialFuel * intKm) - intFuleE;

            if (intFuelLeft > 0)
            {
                int fuel = intFuelLeft / intFuleE;
                Console.WriteLine(Constant.strLftFuel + fuel);
            }
            //else
            //{
            //    try
            //    {
            //        throw new BasicCsharp.NoFuelLeftException();    // Exception
            //    }
            //    catch (BasicCsharp.NoFuelLeftException ex2)
            //    {
            //        Console.WriteLine("No Fuel Left : - ");
            //    }
            //}
        }
    }
    #endregion Armored_Fuel
}
