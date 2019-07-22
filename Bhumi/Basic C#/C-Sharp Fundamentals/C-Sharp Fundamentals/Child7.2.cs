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
    /// Class Name:child
    /// Description://Call the parent method from this method.
    class child:Car
    {
        #region child class which use the functionality of Car class
        ConstantMessage objconst;
        Car objcar;
        /// <summary>
        ///Method Name:GetCarClass
        /// Description://Use the all functionality of Car class
        /// Author:bhumi
        /// Created On:25/5/2015
        /// </summary>
        public void GetCarClass()
        {
            objcar = new Car();
            objconst = new ConstantMessage();            
            objcar.Drive();
            Console.WriteLine(objcar);
        }        
        #endregion
    }
}

