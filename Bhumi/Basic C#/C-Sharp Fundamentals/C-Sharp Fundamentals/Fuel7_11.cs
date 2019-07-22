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
    //Interface
    interface IFuelConsumption
    {
         int FuelEfficiency { get; set; } // Property interface.
         int Drive7_11();
    }
    /// <summary>
    /// Class Name:NoFuelLeftException
    /// Description:Class for exception throw and handling
    /// Author:Bhumi
    /// Created On:25/5/2015
    /// </summary>
    class NoFuelLeftException : Exception
    {
        public NoFuelLeftException()
        {
            Console.WriteLine("No Fuel Remains...");
        }
    }
    /// <summary>
    /// Class Name:Fuel7_11
    /// Description:Create an interface IFuelConsumption 
    /// Author:Bhumi
    /// Created On:25/5/2015
    /// </summary>
    class Fuel7_11 : IFuelConsumption
    {
        ConstantMessage objconst;        
        #region class of Vehicles Namespace
        int kilometer;
        //Properties
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
        /// Description://Method of specific namespace & class 
        /// Author:bhumi
        /// Created On:27/5/2015
        /// </summary>                
        int IFuelConsumption.Drive7_11()
        {
            Console.WriteLine(objconst.strcountkm);
            kilometer = Convert.ToInt32(Console.ReadLine());
            return kilometer;
        }
        /// <summary>
        ///Method Name:NoFuelExe
        /// Description://Method for throw the Exception  
        /// Author:bhumi
        /// Created On:27/5/2015
        /// </summary>                
        public void NoFuelExe()
        {
            objconst = new ConstantMessage();
            throw new NoFuelLeftException();                
        }
        #endregion
    }

}

