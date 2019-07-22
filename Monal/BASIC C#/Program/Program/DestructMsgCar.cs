using System;

namespace Program
{/*--------------------------------------------------------------------------------------------------------------------
        Name:DestructMsgCar.cs
        Author:Monal Shah
        Description:"Add a method to the IVehicle interface named Destruct.
                     Implement this method in the Car class to print "Car destructed"
                     

        CreatedDate: 2010/09/14 by Monal Shah
-------------------------------------------------------------------------------------------------------------------
*/
    class DestructMsgCar:IVehicle
    {


        #region IVehicle Members

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Destruct()
        {
         
            Console.WriteLine("Car Destructed");
      
        }

        #endregion
    }
}
