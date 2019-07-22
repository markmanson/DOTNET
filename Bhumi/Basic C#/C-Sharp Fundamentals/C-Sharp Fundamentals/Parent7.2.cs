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
    /// <summary>
    /// Class Name:Car
    /// Description://"Add class Car to the Vehicles namespace. 
    /// Author:Bhumi
    /// Created On:25/5/2015
    /// </summary>   
    class Car : Vehicle, IVehicle, IFuelConsumption
    {
        #region Car class and inherite this class from Vehicle class
        ConstantMessage objconst;        
        Vehicle objvehicle;//object creation
        int kilometer;

        //Default constructor
        public Car()
        {
        }
        //Parameterized constructor
        public Car(int Initial_Fuel)
        {
            objvehicle = new Vehicle();
            objvehicle.InitialFuel = Initial_Fuel;
        }
        /// <summary>
        ///Method Name:Drive72
        /// Description://method of Car class
        /// Author:bhumi
        /// Created On:25/5/2015
        /// </summary>                            
        public void Drive72()
        {
            objconst = new ConstantMessage();
            objvehicle=new Vehicle();
            Console.WriteLine(objconst.strcarmotion);            
        }
        //Properties
        public string modelnm = "Passenger Car";//local string variable
        public string ModelName
        {
            get
            {
                return modelnm;
            }
            set
            {                            
                modelnm = value;
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
        
        /// <summary>
        ///Method Name:Drive7_11
        /// Description://method of IFuelConsumption interface
        /// Author:bhumi
        /// Created On:27/5/2015
        /// </summary>                            
        int IFuelConsumption.Drive7_11()
        {
            objconst = new ConstantMessage();
            Console.WriteLine(objconst.strcountkm + " Car");
            kilometer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("km Car:" + kilometer);
            return kilometer;                                        
        } 
        #endregion
    }
}
