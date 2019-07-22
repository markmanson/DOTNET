using System;
using System.Collections;
/// <summary>
///NameSpace:Vehicles
/// Description://Fundamental study about Namespaces in C#
/// Author:bhumi
/// Created On:27/5/2015
/// </summary>
namespace Vehicles
{
    /// <summary>
    /// Class Name:Hashtable_Sortedlist
    /// Description://" code to create a hashtable and SortedList."
    /// Author:Bhumi
    /// Created On:25/5/2015
    /// </summary>   
    class Hashtable_Sortedlist
    {
        #region Hashtable & SortedList
        Car objcar;
        ArmoredVehicle objarmored;
        Hashtable objhash;//Hashtable
        SortedList objsortedlist;//SortedList
        /// <summary>
        ///Method Name:GetobjectHashTable
        /// Description://Method of Hashtable & Sortedlist creation 
        /// Author:bhumi
        /// Created On:25/5/2015
        /// </summary>  
        public void GetobjectHashTable()
        {
            try
            {
                objcar = new Car();
                objarmored = new ArmoredVehicle();
                objhash = new Hashtable();
                //Get the objects from car class
                for (int i = 0; i < 3; i++)
                {
                    objhash.Add(i, objcar.ModelName);
                }
                //Get the objects from ArmoredVehicle class
                for (int i = 3; i < 5; i++)
                {
                    objhash.Add(i, objarmored.InitialFuel = 100);
                }
                //output of Hashtable
                foreach (DictionaryEntry de in objhash)
                {
                    Console.WriteLine("{0}, {1}", de.Key, de.Value);
                }
                Console.WriteLine("**************************");
                //output of SortedList
                objsortedlist = new SortedList(objhash);
                foreach (DictionaryEntry de in objsortedlist)
                {
                    Console.WriteLine("{0}, {1}", de.Key, de.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                objcar=null;
                objarmored=null;
                objhash = null;
            }
        }
        #endregion
    }
}
