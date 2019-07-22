using System;

namespace Program
{
    /*-------------------------------------------------------------------------------------------------------------------
        Name:CrateCustomer.cs
        Author:Monal Shah
        Description: Create a class Franchisee as child of the Entity class.
        CreatedDate: 2010/09/09 by Monal Shah
      -------------------------------------------------------------------------------------------------------------------
  

  
      class Frenchisee:Entity means Entity is base class of Frenchisee.
     */
    class Frenchisee:Entity
    {
       
       public int _intFees;//strFees is variable name of string datatype
       public int Fees
       {
           get{return _intFees;}
           set{_intFees = value;}
       }
     
            
        /*---------------------------------------------------------------------------------------------------------------
        Name:ToString
        Paramametres:0
        ReturnType:string
        Description:Format the output.
        Author:Monal Shah
        CreatedDate: 2010/09/09 by Monal Shah
        ---------------------------------------------------------------------------------------------------------------
        */
        public override string ToString()
        {
            return string.Format
           ("\nName:{0}\nMaritalStatus:{1}\nGender:{2}\nAddress:{3}\nFees:{4}",
            _strName,_strMaritalstatus,_strGender,_strAddress, _intFees);
        }
        /*---------------------------------------------------------------------------------------------------------------
    Name:Frenchisee(Constructor is created) 
    Paramametres:string
    Description:get the properties value
    Author:Monal Shah
    CreatedDate: 2010/09/09 by Monal Shah
     ----------------------------------------------------------------------------------------------------------------
    */
        //public Frenchisee(string strName, string strMaritalstatus, string strGender, string strAddress, string strFes)
        //    : base(strName, strMaritalstatus, strGender, strAddress)
        //{
        //    _strName = strName;
        //    _strMaritalstatus = strMaritalstatus;
        //    _strGender = strGender;
        //    _strAddress = strAddress;
        //    _strFees = strFes;


        //}
    }
}
