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
    /// Description://"Add class Car to the Vehicles namespace
    /// Author:Bhumi
    /// Created On:25/5/2015
    /// </summary>   
    class Car7_10 : Vehicle, IVehicle
    {
        #region Car class and inherite this class from Vehicle class
        ConstantMessage objconst;//object creation
        /// <summary>
        ///Method Name:Drive
        /// Description://method of Car class
        /// Author:bhumi
        /// Created On:25/5/2015
        /// </summary>                            
        public void Drive7_10()
        {
            try
            {
                objconst = new ConstantMessage();
                Console.WriteLine(objconst.strcarmotion);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                objconst = null;
            }
        }
        //Propery ModelName       
        public readonly string modelnm;//local string variable
        public string ModelName
        {
            get
            {
                return modelnm;
            }            
        }
        //Parameterized constructor
        public Car7_10(string model_parameter)
        {
            modelnm = model_parameter;
        }
        #endregion
    }
}
