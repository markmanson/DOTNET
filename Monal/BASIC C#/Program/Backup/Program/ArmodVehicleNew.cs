using System;

namespace Program
{
    /*--------------------------------------------------------------------------------------------------------------------
        Name:ArmodVehicleNew.cs
        Author:Monal Shah
        Description:Create an interface IFuelConsumption with a numeric property FuelEfficiency and a method Drive.
                   The method Drive should take a numeric value as the number of kilometres driven.
                   Implement this interface on the Car and ArmoredVehicle classes.
                   Modify the interface IVehicle and add a numeric property InitialFuel.

        CreatedDate: 2010/09/15 by Monal Shah
-------------------------------------------------------------------------------------------------------------------
*/
    class ArmodVehicleNew:IFuelConsumption,INewVehicle
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
        #region ArmodVehicleNew
        /// <summary>
        /// Name:ArmodVehicleNew(constructor)
        ///Author:Monal Shah
        ///Description:get the initial fuel value
        /// </summary>
        /// <param name="intInitialFuel"></param>
        public ArmodVehicleNew(int intInitialFuel)
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
            int intFuelLeft = System.Convert.ToInt32((initialFuel * FuelEfficiency) - fltNumInKM);//here calculate the how much fuel is left
            if (intFuelLeft > 0)
            {
                Console.WriteLine("\nFuel Left in armoredvehicle:{0}", (intFuelLeft / FuelEfficiency));
            }
            else 
            {
                throw new NoFuelLeftException("There is No Fuel Left");
            }

        }
        #endregion
    }
}
