using System;
using CSharp;
/// <summary>
///NameSpace:Vehicles
/// Description://Fundamental study about Namespaces in C#
/// Author:bhumi
/// Created On:25/5/2015
/// </summary>
namespace Vehicles
{
    //Interface Vehicle
    interface vehicle
    {
        void Destruct();//Interface Mehod
    }
    /// <summary>
    /// Class Name:VehicleCannotBeDestroyedException
    /// Description:Exception handling class    
    /// </summary>
    class VehicleCannotBeDestroyedException : Exception
    {
        public VehicleCannotBeDestroyedException(string exception_message)
            : base("Vehicle Cannot Be Destroyed Exception occurred....")
        {            
        }
    }
    /// <summary>
    /// Class Name:ArmoredVehicle
    /// Description:"Change the ArmoredVehicle class so that the Destruct method throws an exception VehicleCannotBeDestroyedException.
    /// Author:Bhumi
    /// Created On:27/5/2015
    /// </summary>   
    class ArmoredVehicle : Exception, vehicle,IFuelConsumption
    {
        #region User Defined Exception
        ConstantMessage objconst;
        public string strvehicleexception = "Vehicle Cannot Be Destroyed Exception occurred....";        
        /// <summary>
        ///Method Name:Destruct
        /// Description://Method of specific namespace & class 
        /// Author:bhumi
        /// Created On:27/5/2015
        /// </summary>
        void vehicle.Destruct()
        {
            objconst=new ConstantMessage();
            try
            {
                Console.WriteLine(objconst.strvehiclenotdestroy);
                throw new VehicleCannotBeDestroyedException(strvehicleexception);
            }
            catch (VehicleCannotBeDestroyedException ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
        //Default constructor
        public ArmoredVehicle()
        {
            
        }
        //Parameterized constructor
        public ArmoredVehicle(int Initial_Fuel)
        {
            initfuel = Initial_Fuel;
        }
        //Properties
        private int initfuel;
        public int InitialFuel
        {
            get
            {
                return initfuel;
            }
            set
            {
                initfuel = value;
            }
        }
        public int fueleff;
        public int FuelEfficiency
        {
            get
            {
                return fueleff;
            }
            set
            {
                fueleff = value;
            }
        }
        //Method of interface
        int IFuelConsumption.Drive7_11()
        {
            objconst = new ConstantMessage();
            int kilometer;
            Console.WriteLine(objconst.strcountkm+"for Armored Vehicle");
            kilometer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("km Armored Vehicle " + kilometer);
            return kilometer;
        }
        #endregion
    }
}
