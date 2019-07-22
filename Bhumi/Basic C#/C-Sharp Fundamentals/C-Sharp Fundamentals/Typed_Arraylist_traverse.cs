using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
/// <summary>
///NameSpace:CSharp
/// Description://Fundamental study programs of C#
/// Author:bhumi
/// Created On:21/5/2015
/// </summary>
namespace CSharp
{
    /// <summary>
    /// Class Name:Typed_Arraylist_traverse
    /// Description:Traverse the arraylists created  by using the Entity class reference and print out the details of each object
    /// Author:
    /// Created On:20/5/2015
    /// </summary>
    /// 
    class Typed_Arraylist_traverse
    {
        #region Traverse Typed Arraylist
        //Traverse the arraylists created above by using the Entity class reference and print out the details of each object
        ///<summary>
        ///Method Name:PrintValues
        /// Description://print the objects with Typed arraylist
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>                                
        public void PrintValues()
        {
            try
            {
                Typed_Arraylist obj = new Typed_Arraylist();               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
