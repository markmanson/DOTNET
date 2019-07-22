using System;
using System.Collections;
using Vehicles;

namespace Basic_C_Sharp
{
    #region HashTblCar
    //NAME          :- HashTblCar
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- Class that methods which create hash table and copy its content into sorted list
    //CREATED DATE  :- 20/07/2012
   public class HashTblCar
    {
        //NAME          :- HashTblSort
        //AUTHOR        :- SHIKHA MALIK
        //DESCRIPTION   :- create hash table and copy its content into sorted list
        //CREATED DATE  :- 20/07/2012
        public void HashTblSort()
        {
            Car objCar; ArmoredVehicle objArmoredVehicle;         //Declaration of object
            try
            {
                Hashtable openWith = new Hashtable();                 //Hash table

                Console.WriteLine(Basic_C_Sharp.Constant.strEntrCarobject);
                int intN = int.Parse(Console.ReadLine());
                for (int i = 0; i < intN; i++)                        //loop for create number of object of car
                {
                    objCar = new Car();
                    openWith.Add(i, objCar);
                    Console.WriteLine(objCar.ToString());
                }
                Console.WriteLine(Basic_C_Sharp.Constant.strEntrArmoredobject);
                int intM = int.Parse(Console.ReadLine());
                for (int i = 0; i < intM; i++)                         //loop for create number of object of Armored vehicle
                {
                    objArmoredVehicle = new ArmoredVehicle();
                    openWith.Add(i + intN, objArmoredVehicle);
                    Console.WriteLine(objArmoredVehicle.ToString());
                }
                Console.WriteLine(Basic_C_Sharp.Constant.strSortedItem);
                SortedList objmySL = new SortedList();                  //create sorted list
                int intSl = 0;
                foreach (object obj in openWith.Values)                 //loop for copy the content of hash table into sorted table
                {
                    objmySL.Add(intSl, obj); intSl++;
                    Console.WriteLine(obj);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                         //Throw exception
            }
            finally
            {
                objCar = null; objArmoredVehicle = null;               //Reallocate memory
            }
   
        }
    }
    #endregion HashTblCar
}
