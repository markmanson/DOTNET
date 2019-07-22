using Vehicles;
using System;
/// <summary>
///NameSpace:Users
/// Description://Fundamental study about Namespaces in C#
/// Author:bhumi
/// Created On:25/5/2015
/// </summary>
namespace Users
{
    /// <summary>
    /// Class Name:Driver
    /// Description://Create class Driver with namespace Users
    /// Author:Bhumi
    /// Created On:25/5/2015
    /// </summary>   
    class Driver
    {
        #region class of Users Namespace        
        ///Method Name:Drive
        /// Description://Method which use the functionality of Vehicles namespace & its class         
        public void Drive()
        {
            Vehicle objvehicle;
            try
            {
                objvehicle = new Vehicle();//object creation
                objvehicle.Drive();//method of Vehicle class which contains in Vehicles namespace 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                objvehicle = null;
            }
        }
        #endregion
    }
}
