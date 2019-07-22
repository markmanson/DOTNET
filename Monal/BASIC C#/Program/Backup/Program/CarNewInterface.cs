using System;

namespace Program
{
    /*--------------------------------------------------------------------------------------------------------------------
       Name:CarNewInterface.cs
       Author:Monal Shah
       Description:Create an interface IFuelConsumption with a numeric property FuelEfficiency and a method Drive.
                  The method Drive should take a numeric value as the number of kilometres driven.
                  Implement this interface on the Car and ArmoredVehicle classes.
                  Modify the interface IVehicle and add a numeric property InitialFuel.

       CreatedDate: 2010/09/15 by Monal Shah
-------------------------------------------------------------------------------------------------------------------
*/
    class CarNewInterface : IFuelConsumption, INewVehicle
    {
        #region initialFuel
        /// <summary>
        ///  Name:initialFuel
        ///Author:Monal Shah
        ///Description:initial fuel property
        /// </summary>
        public int initialFuel
        {
            get;
            set;
        }
        #endregion
        #region FuelEfficiency
        /// <summary>
        ///  Name:FuelEfficiency
        ///Author:Monal Shah
        ///Description:Fuel Efficiency property
        /// </summary>
        public int FuelEfficiency
        {
            get;          
            set;
        }
        #endregion
        #region CarNewInterface
        /// <summary>
        /// Name:CarNewInterface(constructor)
        ///Author:Monal Shah
        ///Description:get the initial fuel value
        /// </summary>
        /// <param name="intInitialFuel"></param>
        public CarNewInterface(int intInitialFuel)
        {
            initialFuel = intInitialFuel;
        }
        #endregion
        #region Drive
        /// <summary>
        /// Name:Drive
        ///Author:Monal Shah
        ///Description:get the KM value
        /// </summary>
        /// <param name="fltNumInKM"></param>
        public void Drive(float fltNumInKM)
        {
            double dblFuelLeft = ((initialFuel * FuelEfficiency) - fltNumInKM);//here calculate the how much fuel is left
            if(dblFuelLeft>0)
            {
                Console.WriteLine("\nFuel Left in carnewinterface:{0}",
                                ((Single)dblFuelLeft / FuelEfficiency));
            }
            else
            {
                Console.WriteLine("There is No Fuel Left");
             //   throw new NoFuelLeftException("There is No Fuel Left");
               
            }
            Console.ReadLine();
        }
        #endregion

    }
}
