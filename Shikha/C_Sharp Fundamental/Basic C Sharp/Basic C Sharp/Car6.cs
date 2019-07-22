using System;
using Vehicles;

namespace Basic_C_Sharp
{
    #region Car6
    //NAME          :- Car6
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- Class that methods and property
    //CREATED DATE  :- 20/07/2012
    class Car6 : IVehicle_11, IFuelConsumption                        //inherit IVehicle_11 ,IFuelConsumption interface
    {
        public Car6(int IntFuel) { InitialFuel = IntFuel; }
        public int InitialFuel { get; set; }
        public int FuelEfficiency { get; set; }                                         //implement interface
        public void Drive() { Console.WriteLine(Basic_C_Sharp.Constant.strCarDes); }
        public double Drive(double dblkilometresDriven)
        {
            double dblAmountOfFuelLeft;                                                      //Declare varible
            double dblJ;
            try
            {
                dblJ = (InitialFuel * FuelEfficiency) - dblkilometresDriven;
                dblAmountOfFuelLeft = Convert.ToDouble(dblJ);
                if (dblAmountOfFuelLeft == 0)
                { throw new NoFuelLeftException(Basic_C_Sharp.Constant.strNoFuelCar); }
                else { Console.WriteLine(Basic_C_Sharp.Constant.strFuelCar + (dblAmountOfFuelLeft / FuelEfficiency)); }
                return 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString()); return 0; }
        }
    }
    #endregion Car6
}
