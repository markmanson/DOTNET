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
    /// Class Name:Vehicle
    /// Description://Create class Vehicle with namespace Vehicles.Add a method Drive to the class.This method should print a message 'Vehicle in motion"".
    /// Author:Bhumi
    /// Created On:25/5/2015
    /// </summary>   
    class Vehicle:IVehicle
    {
        ConstantMessage objconst;
        #region class of Vehicles Namespace
        /// <summary>
        ///Method Name:Drive
        /// Description://Method of specific namespace & class 
        /// Author:bhumi
        /// Created On:25/5/2015
        /// </summary>
        public void Drive()
        {
             objconst= new ConstantMessage();
            Console.WriteLine(objconst.strcarmotion);
        }
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
        void IVehicle.Destruct()
        {
            objconst = new ConstantMessage();
            Console.WriteLine(objconst.strcardestruct);
        }
        #endregion
    }
    
}

