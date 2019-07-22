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
    class Typed_Arraylist
    {        
        /// <summary>
        /// Class Name:Typed_Arraylist
        /// Description://Create typed arraylists with 3 objects of Customer class and 2 objects of Franchisee class
        /// Author:
        /// Created On:20/5/2015
        /// </summary>
        /// 
        #region Typed Arrylist & class Objects
        ////object creation 
        ConstantMessage objconst = new ConstantMessage();           
        Typed_Arraylist objArlist;
        Customer objcustomer;
        Franchisee objfr;                                          
        //Create typed arraylists with 3 objects of Customer class and 2 objects of Franchisee class
        ///<summary>
        ///Method Name:TypedArrayListObj
        /// Description://objects with Typed arraylist
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>                                
            public void TypedArrayListObj()
            {
                try
                {
                    objArlist = new Typed_Arraylist();
                    Console.WriteLine(objconst.typary1);
                    int num_fr = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < num_fr; i++)
                    {
                        // Get the data according to No of Franchisee
                        objArlist.GetTypedArrayList();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            ///<summary>
            ///Method Name:GetTypedArrayList
            /// Description://get the objects with Typed arraylist
            /// Author:bhumi
            /// Created On:21/5/2015
            /// </summary>                                
            public void GetTypedArrayList()
            {
                try
                {
                    objcustomer = new Customer();
                     objfr = new Franchisee();
                    //Salutation, Name, MaritalStatus, Gender, Address, Qualification, Languages
                    Console.WriteLine(objconst.strsalutation);
                    string slt = Console.ReadLine();// set Value of property
                    Console.WriteLine(objconst.strname);
                    string nam = Console.ReadLine();//set Value of property
                    Console.WriteLine(objconst.strMaritalstat);
                    string MarSt = Console.ReadLine();//set Value of property
                    Console.WriteLine(objconst.strgender);
                    string gendr = Console.ReadLine();//set Value of property
                    Console.WriteLine(objconst.straddress);
                    string adr = Console.ReadLine();//set Value of property
                    Console.WriteLine(objconst.strQualification);
                    string qu = Console.ReadLine();//set Value of property
                    Console.WriteLine(objconst.strLanguage);
                    string ln = Console.ReadLine();//set Value of property
                    Console.WriteLine(objconst.strfees);
                    double fees = Convert.ToDouble(Console.ReadLine());                 
                    objcustomer.sl = slt;
                    objcustomer.nm = nam;
                    objcustomer.mst = MarSt;
                    objcustomer.gen = gendr;
                    objcustomer.addrs = adr;
                    objcustomer.qual = qu;
                    objcustomer.lng = ln;
                    objfr.fees_amount = fees;                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            //public override string ToString()
            //{
            //    return String.Format(objcustomer.Salut, objcustomer.Name_customer, objcustomer.Mar_st_customer, objcustomer.Gender_customer, objcustomer.Address_customer, objcustomer.Qualification, objcustomer.language, objfr.Fees);
            //}            
        #endregion
    }    
}
