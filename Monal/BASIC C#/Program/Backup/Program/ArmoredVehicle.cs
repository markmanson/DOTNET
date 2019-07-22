using System;


namespace Program
{ /*--------------------------------------------------------------------------------------------------------------------
        Name:ArmoredVehicle.cs
        Author:Monal Shah
        Description:"Add a method to the IVehicle interface named Destruct.
                     Implement this method in the Car class to print "Car destructed"
                     Create a class ArmoredVehicle which implements the Vehicle interface.  
                     Implement the method Destruct to print "Vehicle cannot be destroyed""

        CreatedDate: 2010/09/14 by Monal Shah
-------------------------------------------------------------------------------------------------------------------
*/
    class ArmoredVehicle:IVehicles
    {
        #region IVehicles Members

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Destruct()
        {
            Console.WriteLine("Vehicle cannot be destroyed");
        }

        #endregion
    }
}
