using System;
using System.Collections;
using Vehicles;

namespace Basic_C_Sharp
{
    #region CarArmoredVcle1
    //NAME          :- CarArmoredVcle1
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- Class that used for create object dynamically
    //CREATED DATE  :- 19/07/2012
    class CarArmoredVcle1
    {
        ArrayList arrLstCarArmd = new ArrayList(); ArmoredVehicle objArmoredVehicle; Car4 objCar4;  //Declaration of variables
        public ArrayList CarArmored()                                                               //create arrayList type class
        {
            try
            {
                Console.WriteLine(Basic_C_Sharp.Constant.strEntrCarobject);
                int intN = int.Parse(Console.ReadLine());
                for (int i = 0; i < intN; i++)                                                      //Loop for crate object of car 
                {
                    objCar4 = new Car4();
                    arrLstCarArmd.Add(objCar4);
                }
                Console.WriteLine(Basic_C_Sharp.Constant.strEntrArmoredobject);
                int intM = int.Parse(Console.ReadLine());
                for (int i = 0; i < intM; i++)                                                      //Loop for crate object of Armored Vehicle
                {
                    objArmoredVehicle = new ArmoredVehicle();
                    arrLstCarArmd.Add(objArmoredVehicle);
                }
                return arrLstCarArmd;
            }
            catch (Exception ex)                                                                  //Throw exception
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally                                                                               //Reallocate memory
            {
                objArmoredVehicle = null;
                objCar4 = null;
            }

        }
    }
    #endregion CarArmoredVcle1
}
