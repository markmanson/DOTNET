using System;
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
    /// Class Name:Arraylist_class
    /// Description://Create arraylist with 3 objects of Customer class and 2 objects of Franchisee class
    /// Author:
    /// Created On:20/5/2015
    /// </summary>
    /// 
    class Arraylist_class
    {
        ConstantMessage objconst = new ConstantMessage();//object creation                    
        Franchisee objfr;
        Arraylist_class objArlist;
        Customer objCustomer;                
        #region Arraylist with Class Objects
        //Create arraylist with 3 objects of Customer class and 2 objects of Franchisee class
        ///<summary>
        ///Method Name:ArrayListObj
        /// Description://Objects in Arraylist
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>  
        ArrayList arrylist;
        public void ArrayListObj()
        {
            try
            {
                Console.WriteLine(objconst.strcustomernum);
                int num_customer = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < num_customer; i++)
                {
                    objArlist = new Arraylist_class();// Get the data according to No of Franchisee
                    objArlist.GetArrayList();
                }
                Console.WriteLine(objconst.strfranchcount);
                int num_fr = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < num_fr; i++)
                {
                    Console.WriteLine(objconst.strfees);
                    objArlist.GetFees();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                
            }
        }
        ///<summary>
        ///Method Name:GetArrayList
        /// Description:// Get Objects in Arraylist
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary> 
        public void GetArrayList()
        {
            try
            {
                arrylist=new ArrayList();
                objCustomer = new Customer();
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
                //ARRAYLIST 
                arrylist.Add(objCustomer.Salut = slt);
                arrylist.Add(objCustomer.Name_customer = nam);
                arrylist.Add(objCustomer.Mar_st_customer = MarSt);
                arrylist.Add(objCustomer.Gender_customer = gendr);
                arrylist.Add(objCustomer.Address_customer = adr);
                arrylist.Add(objCustomer.Qualification = qu);
                arrylist.Add(objCustomer.language = ln);
                //print the values of arraylist
                PrintValues(arrylist);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //cs = null;
                //objfr = null;
            }
        }
        public void GetFees()
        {
            arrylist = new ArrayList();                
            double fees = Convert.ToDouble(Console.ReadLine());
            arrylist.Add(objfr.Fees = fees);
            PrintValues(arrylist);                   
        }


        ///<summary>
        ///Method Name:PrintValues
        /// Description://Print the elements from arraylist
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>                        
        public static void PrintValues(IEnumerable arrylist)
        {
            try
            {
                foreach (Object obj in arrylist)
                {
                    Console.Write("   {0}", obj);
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
